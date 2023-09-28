using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pain
{
    internal class drawer : PictureBox
    {

        float zoom = 1f; 
        public float gridSize = 10f;
        float gridPixelZoomFactor = 1f; //This makes it so zoom is now in units/k pixels
        float zoomInFactor = 0.125f;
        public PointF displacement = new PointF(0f,0f); //how far everything is displaced off the centre (0,0). This means moving the camera x disp -x
        public PointF point1 = new PointF(0f,0f);
        public PointF point2 = new PointF(10f, 0f);
        public PointF point3 = new PointF(0f, 10f);
        public PointF point4 = new PointF(100f, 100f);


        protected override void OnPaint(PaintEventArgs pe)
        {

            base.OnPaint(pe);
            drawGrid(calculateGridPixelSize(zoom, gridSize, gridPixelZoomFactor), pointFToScreenSpace(displacement, zoom, gridPixelZoomFactor), pe.Graphics);
            pe.Graphics.DrawLine(Pens.Blue, worldSpaceToPixelSpace(point1, zoom, displacement), worldSpaceToPixelSpace(point4, zoom, displacement));


        }

        private float calculateGridPixelSize(float zoom, float gridSize, float gridZoomFactor) 
        {
            return(gridSize * (gridZoomFactor / zoom));
        }



        
        /// <summary>
        /// fuck
        /// </summary>
        /// <param name="gridPixelSize"></param>
        /// <param name="displacement"></param>
        /// <param name="g"></param>
        private void drawGrid(float gridPixelSize, PointF displacement, Graphics g) //Give displacment in screen space
        {

            displacement.X = displacement.X % gridPixelSize;
            displacement.Y = displacement.Y % gridPixelSize;


            Pen p = new Pen(Color.Black, 0.1f);

            int sizeWidth = this.Size.Width;
            int sizeHeight = this.Size.Height;

            for (float i = 0; i < sizeWidth + 4; i+= gridPixelSize) 
            {
                g.DrawLine(p, i+ displacement.X, 0, i + displacement.X, sizeHeight);
            }

            for (float j = 0; j < sizeHeight + 4; j += gridPixelSize)
            {
                g.DrawLine(p, 0, j + displacement.Y, sizeWidth, j + displacement.Y);
            }


            

        }





        protected override void OnMouseWheel(MouseEventArgs e)
        {

            base.OnMouseWheel(e);
            if (e.Delta > 0 && zoom > zoomInFactor)
            {
                float oldZoom = zoom;
                zoom -= zoomInFactor;
                displacement.X -= ((float)e.X/(float)this.Width) * ((this.Width*oldZoom)- (this.Width * zoom));
                displacement.Y -= ((float)e.Y / (float)this.Height) * ((this.Height * oldZoom) - (this.Height * zoom));
                Invalidate();
            }

            else if (e.Delta < 0)
            {
                float oldZoom = zoom;
                zoom += zoomInFactor;
                displacement.X -= ((float)e.X / (float)this.Width) * ((this.Width * oldZoom) - (this.Width * zoom));
                displacement.Y -= ((float)e.Y / (float)this.Height) * ((this.Height * oldZoom) - (this.Height * zoom));
                Invalidate();
            }




        }



        public PointF pointFToScreenSpace(PointF displacement, float zoom, float gridPixelZoomFactor)
        {
            displacement.X *= gridPixelZoomFactor / zoom;
            displacement.Y *= gridPixelZoomFactor / zoom;
            return displacement;
        }

        public PointF worldSpaceToPixelSpace(PointF point, float zoom, PointF displacement) 
        {
            return new PointF((point.X + displacement.X) / zoom, (point.Y + displacement.Y) / zoom);
        }

    }

}

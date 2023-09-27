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
        public PointF displacement = new PointF(25f,2f);


        protected override void OnPaint(PaintEventArgs pe)
        {

            base.OnPaint(pe);
            drawGrid(calculateGridPixelSize(zoom, gridSize, gridPixelZoomFactor), pointFToScreenSpace(displacement, zoom, gridPixelZoomFactor), pe.Graphics);
            
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
            Debug.WriteLine(gridPixelSize);
            Debug.WriteLine(displacement);
            displacement.X = displacement.X % gridPixelSize;
            displacement.Y = displacement.Y % gridPixelSize;
            Debug.WriteLine(displacement);


            Pen p = new Pen(Color.Black, 0.1f);

            int sizeWidth = this.Size.Width;
            int sizeHeight = this.Size.Height;

            for (float i = 0; i < sizeWidth + 2; i+= gridPixelSize) 
            {
                g.DrawLine(p, i- displacement.X, 0, i - displacement.X, sizeHeight);
            }

            for (float j = 0; j < sizeHeight + 2; j += gridPixelSize)
            {
                g.DrawLine(p, 0, j - displacement.Y, sizeWidth, j - displacement.Y);
            }


            

        }





        protected override void OnMouseWheel(MouseEventArgs e)
        {

            base.OnMouseWheel(e);
            if (e.Delta > 0 && zoom > zoomInFactor)
            {
                zoom -= zoomInFactor;
                Invalidate();
            }

            else if (e.Delta < 0)
            {
                zoom += zoomInFactor;
                Invalidate();
            }




        }



        public PointF pointFToScreenSpace(PointF displacement, float zoom, float gridPixelZoomFactor)
        {
            displacement.X *= gridPixelZoomFactor / zoom;
            displacement.Y *= gridPixelZoomFactor / zoom;
            return displacement;
        }

        public PointF displacementToPixels(PointF displacement, float zoom, float gridPixelZoomFactor, float gridSize) 
        {
            return PointF.Empty;
        }
    }

}

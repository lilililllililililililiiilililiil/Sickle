using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pain
{
    public partial class Form1 : Form
    {

        List<drawer> allDrawers = new List<drawer>();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            allDrawers.AddRange(new List<drawer> { XY,XZ,XW,YZ,YW,ZW});

        }

        private void XY_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (drawer item in allDrawers)
            {
                item.gridSize += 1;
                item.Invalidate();
            }
        }

        public int findHexant(PointF mousePos)
        {
            int hexantPos = 0;
            float xPosDec = mousePos.X / this.Width; //gives a percentage on screen you are
            if (0.6667f <= xPosDec && xPosDec < 1f)
            {
                hexantPos += 2;
            }
            else if (0.3333f <= xPosDec && xPosDec < 0.6667f)
            {
                hexantPos += 1;
            }


            float yPosDec = mousePos.Y / this.Height;
            if (0.5f <= yPosDec && yPosDec < 1f) 
            {
                hexantPos += 3;
            }
            return hexantPos;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Debug.WriteLine(findHexant(MousePosition));
            //Debug.WriteLine(MousePosition);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        
            switch (e.KeyCode)
            {
                case Keys.W:
                    XY.displacement.Y += 7;
                    break;
                case Keys.A:
                    XY.displacement.X += 7;
                    break;
                case Keys.S:
                    XY.displacement.Y -= 7;
                    break;
                case Keys.D:
                    XY.displacement.X -= 7;
                    break;
                default:
                    break;
        
            }
            XY.Invalidate();
        }
    }



}

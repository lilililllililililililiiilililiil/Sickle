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
        int currentHexant = 0;
        
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


        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
        
            switch (e.KeyCode)
            {
                case Keys.W:
                    allDrawers[currentHexant].displacement.Y += 7;
                    break;
                case Keys.A:
                    allDrawers[currentHexant].displacement.X += 7;
                    break;
                case Keys.S:
                    allDrawers[currentHexant].displacement.Y -= 7;
                    break;
                case Keys.D:
                    allDrawers[currentHexant].displacement.X -= 7;
                    break;
                default:
                    break;
        
            }
            allDrawers[currentHexant].Invalidate();
        }

        private void XY_MouseEnter(object sender, EventArgs e)
        {
            currentHexant = 0;
        }
        private void XZ_MouseEnter(object sender, EventArgs e)
        {
            currentHexant = 1;
        }
        private void XW_MouseEnter(object sender, EventArgs e)
        {
            currentHexant = 2;
        }
        private void YZ_MouseEnter(object sender, EventArgs e)
        {
            currentHexant = 3;
        }
        private void YW_MouseEnter(object sender, EventArgs e)
        {
            currentHexant = 4;
        }
        private void ZW_MouseEnter(object sender, EventArgs e)
        {
            currentHexant = 5;
        }
    }



}

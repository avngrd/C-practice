using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = CreateGraphics();
            g.Clear(Color.White);
            g.DrawEllipse(Pens.Green,98, 98, 198, 198);
            g.FillEllipse(Brushes.Red, 98,98,198,198);
            g.FillEllipse(Brushes.Black, 158, 128, 10, 10);
            g.FillEllipse(Brushes.Black, 158, 188, 10, 10);
            g.FillEllipse(Brushes.Black, 200, 118, 10, 10);
            g.FillEllipse(Brushes.Black, 118, 200, 10, 10);
            g.FillEllipse(Brushes.Black, 158,200, 10, 10);
            g.FillEllipse(Brushes.Black, 210, 150, 10, 10);
            g.FillEllipse(Brushes.Black, 150, 210, 10, 10);
            g.FillEllipse(Brushes.Black, 200,158, 10, 10);
            g.FillEllipse(Brushes.Black, 250, 258, 10, 10);
            g.FillEllipse(Brushes.Black, 130, 250, 10, 10);
            g.FillEllipse(Brushes.Black, 200, 200, 10, 10);
            g.FillEllipse(Brushes.Black, 220, 220, 10, 10);
            g.FillEllipse(Brushes.Black, 240, 240, 10, 10);
            g.FillEllipse(Brushes.Black, 280, 220, 10, 10);
            g.FillEllipse(Brushes.Black, 180, 220, 10, 10);
            g.FillPie(Brushes.White, 101, 101, 198,198,0,90);
        }
    }
}

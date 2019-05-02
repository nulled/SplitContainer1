using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSC
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
        }

        private void Form4_Paint(object sender, PaintEventArgs e)
        {
            Pen drawingPen = new Pen(Color.Red, 13);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // two ways to GDI draw using CreateGraphics or from the Paint event
            Graphics gdiSurface = this.CreateGraphics();
            Rectangle rect = new Rectangle(new Point(0, 0), new Size(50, 50));
            gdiSurface.DrawRectangle(drawingPen, rect);
            gdiSurface.FillRectangle(Brushes.Blue, rect);

            // method 2 using e Paint Event
            e.Graphics.DrawArc(drawingPen, 5, 5, 50, 100, 40, 210);
            e.Graphics.DrawString("Test", new Font("Times", 50), Brushes.Black, 50, 50);
            drawingPen.Dispose();

            // sleep 10 milliseconds to show what was painted, using it here to illustrate Sleep()
            System.Threading.Thread.Sleep(10);
        }
    }
}

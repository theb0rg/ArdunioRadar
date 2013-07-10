using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using GDIDB;

namespace ArdunioRadar
{
    public partial class ArdunioRadarControl : UserControl
    {
        private DBGraphics memGraphics;
        //private DrawObject drawObj;

        public ArdunioRadarControl()
        {
            InitializeComponent();
            pings = new List<PingResponse>();
            pen = new Pen(Color.Black);
            pen.Width = 5;

            memGraphics = new DBGraphics();
            //drawObj = new DrawObject();
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
        }

        private List<PingResponse> pings;
        private Pen pen;

        public void UpdateRadar(PingResponse response)
        {
            pings.Add(response);
        }

        public void Clear()
        {
            pings.Clear();
        }

        private int test = 0;
        private void ArdunioRadarControl_Paint(object sender, PaintEventArgs e)
        {
            if (memGraphics.CanDoubleBuffer())
            {

                // Fill in Background (for effieciency only the area that has been clipped)
                memGraphics.g.FillRectangle(new SolidBrush(SystemColors.Window), e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width, e.ClipRectangle.Height);

                foreach (PingResponse response in pings)
                {
                    DrawScanner(response.Degree, memGraphics.g);
                }

                DrawScanner(0, memGraphics.g);
                //if (test > 180)
               //     test = 0;
               // test++;


                //memGraphics.g.DrawLine(pen, 0, 0, 10, 15);
                // Draw the object
                //drawObj.Draw(memGraphics.g);

                // Render to the form
                memGraphics.Render(e.Graphics);

           // Graphics g = e.Graphics;
            //pings = pings.FindAll(X => X.timestamp > DateTime.Now - TimeSpan.FromSeconds(3));

           
            }
        }

        private void DrawScanner(int degree, Graphics g)
        {
            degree = degree - 90;

            int width = 40;
            int height = 50;

            SizeF sz = g.VisibleClipBounds.Size;

           // g.DrawLine(pen, sz.Width / 2, 150, sz.Width / 2 + 1, 150);

            g.ResetTransform();

            g.RotateTransform(degree, MatrixOrder.Append);  // then rotate
            g.TranslateTransform(sz.Width / 2, sz.Height - height, MatrixOrder.Append);// first translate

            g.DrawEllipse(pen, new Rectangle(width - width, 0 - height, width, height));
            g.DrawEllipse(pen, new Rectangle(0 - width, 0 - height, width, height));
            g.DrawLine(pen, width - width - width, 0, width, 0);

            g.ResetTransform();
        }

        private void ArdunioRadarControl_Load(object sender, EventArgs e)
        {
            memGraphics.CreateDoubleBuffer(this.CreateGraphics(), this.ClientRectangle.Width, this.ClientRectangle.Height);
        }


    }
}

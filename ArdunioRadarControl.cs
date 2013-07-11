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
        private PingResponse LastPing()
        {
           // List<DateTime> dates = new List<DateTime> { DateTime.Now, DateTime.MinValue, DateTime.MaxValue };
            PingResponse newestPing = new PingResponse(90,0);
            newestPing.timestamp = DateTime.MinValue;
            foreach (PingResponse ping in pings)
            {
                if (DateTime.Compare(ping.timestamp, newestPing.timestamp) == 1)
                    newestPing = ping;
            }

            return newestPing;
        }
        private int test = 0;
        private void ArdunioRadarControl_Paint(object sender, PaintEventArgs e)
        {
            if (memGraphics.CanDoubleBuffer())
            {

                // Fill in Background (for effieciency only the area that has been clipped)
                memGraphics.g.FillRectangle(new SolidBrush(SystemColors.Window), e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.Width, e.ClipRectangle.Height);

                if(pings.Any())
                {
                DrawScanner(pings.Last().Degree, memGraphics.g);
                }
                else{
                DrawScanner(90, memGraphics.g);
                }

                foreach (PingResponse response in pings)
                {
                    Point HitPoint = CalculateHitPoint(response.Degree, response.Distance, 400);
                    memGraphics.g.DrawRectangle(pen, new Rectangle(HitPoint, new Size(1, 1)));
                }

                // Render to the form
                memGraphics.Render(e.Graphics);

           // Graphics g = e.Graphics;
              pings = pings.FindAll(X => X.timestamp > DateTime.Now - TimeSpan.FromSeconds(2));
            }
        }

        private Point CalculateHitPoint(int degree, int length, int MaxLength)
        {
            SizeF sz = memGraphics.g.VisibleClipBounds.Size;

            int x1 = (int)(sz.Width / 2);
            int y1 = (int)(sz.Height - 50);

            Point StartPoint = new Point(x1, y1);
            return CalculateHitPoint(StartPoint, degree, length, MaxLength);
        }
        private Point CalculateHitPoint(Point startPoint, int degree, int length, int MaxLength)
        {
            SizeF sz = memGraphics.g.VisibleClipBounds.Size;
            double ads = (sz.Height * 0.75) / MaxLength;
            length = (int)((double)length * ads);

            double angleRadians = ((Math.PI / 180.0) * (degree - 180));
            double x1 = startPoint.X;
            double y1 = startPoint.Y;
            double x2 = x1 + (Math.Cos(angleRadians) * length);
            double y2 = y1 + (Math.Sin(angleRadians) * length);
            int intX1 = Convert.ToInt32(x1);
            int intY1 = Convert.ToInt32(y1);
            int intX2 = Convert.ToInt32(x2);
            int intY2 = Convert.ToInt32(y2);

            return new Point(intX2, intY2);
        }

        private void DrawScannerLine(int degree,int length, Graphics g)
        {
            SizeF sz = memGraphics.g.VisibleClipBounds.Size;

            int x1 = (int)(sz.Width / 2);
            int y1 = (int)(sz.Height - 50);

            Point StartPoint = new Point(x1, y1);
            Point EndPoint   = CalculateHitPoint(StartPoint,degree,length,400);

            float[] dashValues = { 1, 1, 1, 1};
            Pen DottedPen = (Pen)pen.Clone();
            DottedPen.DashPattern = dashValues;
            DottedPen.Width = 2;
            DottedPen.Color = Color.Green;
            memGraphics.g.DrawLine(DottedPen, StartPoint, EndPoint);
        }

        private void DrawScanner(int degree, Graphics g)
        {
            DrawScannerLine(degree,400, g);   

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

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOP_Lab4
{
    public class Triangle : Figure
    {
        private Point point1, point2, point3;

        public Triangle()
        {
            Random randomint = new Random();
            int r = randomint.Next(0, 150);
            point1 = new Point();
            point2 = new Point();
            point3 = new Point();
            this.point1.X = randomint.Next(x - r, x + r);
            this.point1.Y = randomint.Next(y - r, y + r);
            this.point2.X = randomint.Next(x - r, x + r);
            this.point2.Y = randomint.Next(y - r, y + r);
            this.point3.X = randomint.Next(x - r, x + r);
            this.point3.Y = randomint.Next(y - r, y + r);
        }

        public Triangle(int x, int y, int x1, int y1, int x2, int y2, int x3, int y3, bool visibility, int redcolor, int greencolor, int bluecolor) : base(x, y, visibility, redcolor, greencolor, bluecolor)
        {
            point1 = new Point(x1, y1);
            point2 = new Point(x2, y2);
            point3 = new Point(x3, y3);
            base.visibility = visibility;
            base.redcolor = redcolor;
            base.greencolor = greencolor;
            base.bluecolor = bluecolor;
        }

        public override void Show(PictureBox pictureBox1)
        {
            if (visibility == true)
            {
                if (pictureBox1.Image == null)
                {
                    Bitmap newbmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                    using (Graphics gr = Graphics.FromImage(newbmp))
                    {
                        gr.Clear(Color.White);
                    }
                    pictureBox1.Image = newbmp;
                }
                using (Graphics gr = Graphics.FromImage(pictureBox1.Image))
                {
                    gr.FillPolygon(new SolidBrush(Color.FromArgb(redcolor, greencolor, bluecolor)), new[] { new PointF(point1.X, point1.Y), new PointF(point2.X, point2.Y), new PointF(point3.X, point3.Y) });
                    if (redcolor == 0 && greencolor == 0 && bluecolor == 0)
                    {
                        gr.DrawPolygon(new Pen(Color.White), new[] { new PointF(point1.X, point1.Y), new PointF(point2.X, point2.Y), new PointF(point3.X, point3.Y) });
                    }
                    else
                    {
                        gr.DrawPolygon(new Pen(Color.Black), new[] { new PointF(point1.X, point1.Y), new PointF(point2.X, point2.Y), new PointF(point3.X, point3.Y) });
                    }
                }
                pictureBox1.Invalidate();
            }
        }

        public override void MoveTo(int x, int y)
        {
            this.point1.X += x;
            this.point2.X += x;
            this.point3.X += x;
            this.point1.Y += y;
            this.point2.Y += y;
            this.point3.Y += y;
        }
    }
}

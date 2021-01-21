using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOP_Lab4
{
    public class Parallelogram : Rectangle
    {
        private int alpha { get; set; }

        public Parallelogram()
        {
            Random randomint = new Random();
            this.alpha = randomint.Next(10, 170);
        }

        public Parallelogram(int x, int y, int w, int h, int alpha, bool visibility, int redcolor, int greencolor, int bluecolor) : base(x, y, w, h, visibility, redcolor, greencolor, bluecolor)
        {
            this.alpha = alpha;
        }

        public override void Show(PictureBox pictureBox1)
        {
            Point point1 = new Point();
            Point point2 = new Point();
            Point point3 = new Point();
            Point point4 = new Point();
            point1.X = base.x;
            point1.Y = base.y;
            point2.X = base.x + base.w;
            point2.Y = base.y;
            if (alpha <= 90)
            {
                point3.X = base.x - Convert.ToInt16(base.h / Math.Tan(alpha));
            }
            else
            {
                point3.X = base.x + Convert.ToInt16(base.h / Math.Tan(alpha));
            }
            point3.Y = base.y + base.h;
            point4.X = point3.X + base.w;
            point4.Y = base.y + base.h;
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
                    gr.FillPolygon(new SolidBrush(Color.FromArgb(redcolor, greencolor, bluecolor)), new[] { point1, point2, point4, point3 });
                    if (redcolor == 0 && greencolor == 0 && bluecolor == 0)
                    {
                        gr.DrawPolygon(new Pen(Color.White), new[] { point1, point2, point4, point3 });
                    }
                    else
                    {
                        gr.DrawPolygon(new Pen(Color.Black), new[] { point1, point2, point4, point3 });
                    }
                }
                pictureBox1.Invalidate();
            }
        }

        public override void MoveTo(int x, int y)
        {
            this.x += x;
            this.y += y;

        }
    }
}

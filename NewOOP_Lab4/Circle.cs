using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NewOOP_Lab4
{
    public class Circle : Figure
    {
        public int r { get; private set; }

        public Circle()
        {
            Random randomint = new Random();
            this.r = randomint.Next(0, 150);
        }

        public Circle(int x, int y, int r, bool visibility, int redcolor, int greencolor, int bluecolor) : base(x, y, visibility, redcolor, greencolor, bluecolor)
        {
            this.r = r;
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
                    gr.FillEllipse(new SolidBrush(Color.FromArgb(redcolor, greencolor, bluecolor)), x - r, y - r, 2 * r, 2 * r);
                    if (redcolor == 0 && greencolor == 0 && bluecolor == 0)
                    {
                        gr.DrawEllipse(new Pen(Color.White), x - r, y - r, 2 * r, 2 * r);
                    }
                    else
                    {
                        gr.DrawEllipse(new Pen(Color.Black), x - r, y - r, 2 * r, 2 * r);
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

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOP_Lab4
{
    public class Rectangle : Figure
    {

        public int w { get; private set; }
        public int h { get; private set; }

        public Rectangle()
        {
            Random randomint = new Random();
            this.w = randomint.Next(0, 150);
            this.h = randomint.Next(0, 150);
        }

        public Rectangle(int x, int y, int w, int h, bool visibility, int redcolor, int greencolor, int bluecolor) : base(x, y, visibility, redcolor, greencolor, bluecolor)
        {
            this.w = w;
            this.h = h;
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
                    gr.FillRectangle(new SolidBrush(Color.FromArgb(redcolor, greencolor, bluecolor)), x, y, w, h);
                    if (redcolor == 0 && greencolor == 0 && bluecolor == 0)
                    {
                        gr.DrawRectangle(new Pen(Color.White), x, y, w, h);
                    }
                    else
                    {
                        gr.DrawRectangle(new Pen(Color.Black), x, y, w, h);
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

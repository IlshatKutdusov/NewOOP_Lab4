using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewOOP_Lab4
{
    public abstract class Figure
    {
        public int x { get; set; }
        public int y { get; set; }
        public bool visibility;
        public int redcolor { get; set; }
        public int greencolor { get; set; }
        public int bluecolor { get; set; }

        public Figure()
        {
            Random randomint = new Random();
            this.x = randomint.Next(0, 1054);
            this.y = randomint.Next(0, 685);
            this.visibility = true;
            this.redcolor = randomint.Next(0, 256);
            this.greencolor = randomint.Next(0, 256);
            this.bluecolor = randomint.Next(0, 256);
        }

        public Figure(int x, int y, bool visibility, int redcolor, int greencolor, int bluecolor)
        {
            this.x = x;
            this.y = y;
            this.visibility = visibility;
            this.redcolor = redcolor;
            this.greencolor = greencolor;
            this.bluecolor = bluecolor;
        }

        public abstract void Show(PictureBox pictureBox1);
        public abstract void MoveTo(int x, int y);

        public void Visibility()
        {
            if (visibility == false)
            {
                visibility = true;
            }
            else
            {
                visibility = false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    internal class ellipse:shape
    {
        public override void draw(Graphics g)
        {
            base.draw(g);
            int width = p2.X - p1.X;
            int height = p2.Y - p1.Y;

            if (isFill)
            {
                SolidBrush brush = new SolidBrush(pen.Color);
                Rectangle rec = new Rectangle(p1.X, p1.Y, width, height);
                g.FillEllipse(brush, rec);
            }
            else
                g.DrawEllipse(pen, p1.X, p1.Y, width, height);
        }
    }
}

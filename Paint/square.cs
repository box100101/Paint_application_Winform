using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    internal class square:shape
    {
        public override void draw(Graphics g)
        {
            base.draw(g);
            int width = p2.X - p1.X;
            int height = p2.Y - p1.Y;
            int size;

            if (width > height)
                size = width;
            else
                size = height;

            if (isFill)
            {
                SolidBrush brush = new SolidBrush(pen.Color);
                g.FillRectangle(brush, new Rectangle(p1.X, p1.Y, size, size));
            }
            else
                g.DrawRectangle(pen, p1.X, p1.Y, size, size);
        }
    }
}

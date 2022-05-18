using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    internal class rectangle : shape
    {
        
        public override void draw(Graphics g)
        {
            base.draw(g);
            if (isFill)
            {
                SolidBrush brush = new SolidBrush(pen.Color);
                g.FillRectangle(brush, new Rectangle(p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y));
            }
            else
                g.DrawRectangle(pen, p1.X, p1.Y, p2.X - p1.X, p2.Y - p1.Y);
        }
    }
}

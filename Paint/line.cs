using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    internal class line:shape
    {
        public override void draw(Graphics g)
        {
            base.draw(g);
            g.DrawLine(pen, p1, p2);
        }
    }
}

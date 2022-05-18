using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Paint
{
    internal class shape
    {
        public Point p1 { get; set; }
        public Point p2 { get; set; }
        public bool isFill { get; set; }
        public Pen pen { get; set; }

        public virtual void draw(Graphics g)
        {
            
        }
    }
}

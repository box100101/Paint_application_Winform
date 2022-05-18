using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint
{
    internal class polygon:shape
    {
        public override void draw(Graphics g)
        {
            base.draw(g);
            int width = p2.X - p1.X;
            int height = p2.Y - p1.Y;
            int point_width = width / 4;
            int point_height = height / 2;

            List<Point> points = new List<Point>();

            Point point_1 = new Point(p1.X + point_width, p1.Y);
            points.Add(point_1);
            Point point_2 = new Point(p1.X + point_width * 3, p1.Y);
            points.Add(point_2);
            Point point_3 = new Point(p1.X + point_width * 4, p1.Y + point_height);
            points.Add(point_3);
            Point point_4 = new Point(p1.X + point_width * 3, p1.Y + point_height * 2);
            points.Add(point_4);
            Point point_5 = new Point(p1.X + point_width, p1.Y + point_height * 2);
            points.Add(point_5);
            Point point_6 = new Point(p1.X, p1.Y + point_height);
            points.Add(point_6);


            if (isFill)
            {
                SolidBrush brush = new SolidBrush(pen.Color);
                g.FillPolygon(brush, points.ToArray());
            }
            else
                g.DrawPolygon(pen,points.ToArray());
        }
    }
}

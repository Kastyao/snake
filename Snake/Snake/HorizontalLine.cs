using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        List<Point> hLine;

        public HorizontalLine(int leftX, int rightX, int y, char symb)
        {
            hLine = new List<Point>();
            for (int x = leftX; x <= rightX; x++)
            {
                Point p = new Point(x, y, symb);
                hLine.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in hLine)
            {
                p.Draw();
            }
        }
    }
}

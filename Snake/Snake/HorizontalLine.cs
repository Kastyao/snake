﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {       
        public HorizontalLine(int leftX, int rightX, int y, char symb)
        {
            line = new List<Point>();
            for (int x = leftX; x <= rightX; x++)
            {
                Point p = new Point(x, y, symb);
                line.Add(p);
            }
        }
        
    }
}

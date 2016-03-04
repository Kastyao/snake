using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char symb;

        public Point()
        {
        }

        public Point(int x, int y, char symb)
        {
            this.x = x;
            this.y = y;
            this.symb = symb;
        }

        public Point(Point p)
        {
            this.x = p.x;
            this.y = p.y;
            this.symb = p.symb;
        }

        public void Move(int offset, Direction direction)
        {            
            switch (direction)
            {
                case Direction.DOWN:
                    {
                        y += offset;
                        break;
                    }
                case Direction.UP:
                    {
                        y -= offset;
                        break;
                    }
                case Direction.RIGHT:
                    {
                        x += offset;
                        break;
                    }
                case Direction.LEFT:
                    {
                        x -= offset;
                        break;
                    }
                default: break;
            }
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }
    }
}

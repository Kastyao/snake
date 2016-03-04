using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 30);

            Point p1 = new Point(1,3,'*');
                  //p1.Draw();

            Point p2 = new Point(4,5,'#');
            //p2.Draw();

            HorizontalLine hLineTop = new HorizontalLine(0, 119, 0, '+');
                hLineTop.Draw();
            HorizontalLine hLineLow = new HorizontalLine(0, 119, 28, '+');
                hLineLow.Draw();

            VerticalLine vLineLeft = new VerticalLine(0, 0, 28, '+');
                vLineLeft.Draw();
            VerticalLine vLineRight = new VerticalLine(119, 0, 28, '+');
                vLineRight.Draw();

            Console.ReadLine();
        }
    }
}

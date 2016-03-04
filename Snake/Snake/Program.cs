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
                        
            HorizontalLine hLineTop = new HorizontalLine(0, 119, 0, '+');              
            HorizontalLine hLineLow = new HorizontalLine(0, 119, 28, '+');     
            VerticalLine vLineLeft = new VerticalLine(0, 0, 28, '+');
            VerticalLine vLineRight = new VerticalLine(119, 0, 28, '+');

            hLineTop.Draw();
            hLineLow.Draw();
            vLineLeft.Draw();
            vLineRight.Draw();

            Point tail = new Point(4, 15, '*');

            Snake snake = new Snake(tail, 5, Direction.UP);
            snake.Draw();
            Console.ReadLine();
        }
    }
}

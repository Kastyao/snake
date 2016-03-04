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


            Point p1 = new Point(1,3,'*');
                  //p1.Draw();

            Point p2 = new Point(4,5,'#');           
                  //p2.Draw();

            List<Point> pointsList = new List<Point>();
            pointsList.Add( new Point(1, 3, '*'));
            pointsList.Add( new Point(4, 5, '#'));
            pointsList.Add( new Point(5, 6, '░'));
            pointsList.Add( new Point(6, 8, '*'));
            
            for(int i=0; i<pointsList.Count; i++)
            {
                pointsList[i].Draw();
            }

            Console.ReadLine();
        }
    }
}

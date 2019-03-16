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
            Point p1 = new Point( 2, 3, '@' );
            p1.Draw();

            Point p2 = new Point( 3, 4, '@');       
            p2.Draw();

            Point p3 = new Point(4, 5, '@');
            p3.Draw();

            Point p4 = new Point(5, 6, '@');
            p4.Draw();

            HorizontLine line = new HorizontLine(2, 40, 7, '_');
            line.Drow();

            VerticalLine vline = new VerticalLine(2, 8, 40, '|');
            vline.Drow();


            Console.ReadLine();

        }
        
    }

}

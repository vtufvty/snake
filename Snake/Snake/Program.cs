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
            /*Point p1 = new Point( 2, 3, '@' );
            p1.Draw();

            Point p2 = new Point( 3, 4, '@');       
            p2.Draw();

            Point p3 = new Point(4, 5, '@');
            p3.Draw();

            Point p4 = new Point(5, 6, '@');
            p4.Draw();*/

            Console.SetBufferSize(80, 25);

            HorizontLine upline = new HorizontLine(0, 78, 0, '_');
            HorizontLine downline = new HorizontLine(0, 78, 24, '_');
            VerticalLine Leftline = new VerticalLine(0, 1, 24, '|');
            VerticalLine Rightline = new VerticalLine(78, 1, 24, '|');
            upline.Drow();
            downline.Drow();
            Leftline.Drow();
            Rightline.Drow();

            Point p = new Point(2, 3, '@');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            Console.ReadLine();

        }
        
    }

}

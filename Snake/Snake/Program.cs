﻿using System;
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

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);

       

            Console.ReadLine();

        }
        
    }

}

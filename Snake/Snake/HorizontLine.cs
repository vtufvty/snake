﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontLine
    {
        List<Point> pList;

        public HorizontLine(int xleft, int xReight, int y, char sym)
        {
            pList = new List<Point>();
            for(int x = xleft; x <= xReight; x++)
            {
                Point p = new Point( x, y, sym );
                pList.Add(p);
            }
        }

        public void Drow()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}

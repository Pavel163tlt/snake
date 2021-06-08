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
            
            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            line.Drow();
            VerticalLine line2 = new VerticalLine(9, 14, 11, '+'); 
            line2.Drow();
                       
        }
       
    }
}

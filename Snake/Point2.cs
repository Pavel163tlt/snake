using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point2
    {
        public int y;
        public int x;
        public int sym;

        public Point2(int _y, int _x, char _sym)
        {
            y = _y;
            x = _x;
            sym = _sym;
        }
        public void Draw2()
        {
            Console.SetCursorPosition(y, x);
            Console.Write(sym);
        }
    }
}

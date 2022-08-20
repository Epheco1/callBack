using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallBack
{
    internal static class SquareClass
    {
        public delegate void Square(int number);
        public static void SquareCalculator(Square hf)
        {
            List<int> squaresList;
            for (int i = 0; i <= 4000; i++)
            {
                var square = i * i;
                squaresList = new List<int>(square);
                hf(i);
            }
        }
    }
}

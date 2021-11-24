using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class Fibonacci
    {
        public int Counter = 1;
        public long Calculator(long num)
        {
            if (num == 0)
            {
                Counter++;
            }

            if (num <= 1)
            {
                return num;
            }
            else
            {
                return  Calculator(num - 1) + Calculator(num - 2);
            }
        }
    }
}

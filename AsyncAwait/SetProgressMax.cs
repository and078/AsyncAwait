using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    class SetProgressMax
    {
        static public int FibLoop(int term)
        {
            int res = 0;
            int a = 0;
            int b = 1;
            for (int i = 0; i < term; i++)
            {
                if (i <= 1)
                {
                    res = i;
                }
                else
                {
                    res = a + b;
                    a = b;
                    b = res;
                }
            }
            return res;
        }
    }
}

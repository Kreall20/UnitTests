using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2console
{
    public class Fibonacci
    {
        public int maxvalue = 50;
        public int minvalue = 1;

        public long FibonachiByIndex(int n)
        {
            long a = 0, b = 1, c = 0;
            if (n > maxvalue || n < minvalue)
            {
                return -1;
            }
            switch (n)
            {
                case 1:
                    return 1;
                case 2:
                    return 1;
                default:
                    for (int i = 1; i < n; i++)
                    {
                        c = a + b;
                        a = b;
                        b = c;
                    }
                    return c;
            }
        }
    }
}

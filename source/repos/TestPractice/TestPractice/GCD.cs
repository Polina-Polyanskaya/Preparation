using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice
{
    public class GCD
    {
        public long Gcd(long x, long y)
        {
            long t;

            if (x < 0) x = -x;
            if (y < 0) y = -y;

            while (y != 0)
            {
                if (y > x)
                {
                    x = y - x;
                    y = y - x;
                    x = x + y;
                }

                if (y == 0) 
                    return x;

                t = y;
                y = x % y;
                x = t;
            }
            return x;
        }
    }

}

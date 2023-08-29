using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lgLeetCodePractice
{
    public class DivideTwoIntegersSolver
    {
        public int Divide(int dividend, int divisor)
        {
            if(divisor == 0)
            {
                return 0;
            }
            else if (dividend == 0)
            {
                return 0;
            }

            if (divisor == 1)
            {
                return dividend;
            }

            if (divisor == -1)
            {
                if (dividend == Int32.MinValue)
                {
                    return Int32.MaxValue;
                }
                else
                {
                    return -dividend;
                }
            }

            int i = 0;
            if (dividend >= 0 && divisor > 0)
            {
                while (dividend >= divisor)
                {
                    dividend -= divisor;
                    i++;
                }
            }
            else if (dividend < 0 && divisor < 0)
            {
                while (dividend <= divisor)
                {
                    dividend -= divisor;
                    i++;
                }
            }
            else if (dividend >= 0 && divisor < 0)
            {
                while (-dividend <= divisor)
                {
                    dividend += divisor;
                    i--;
                }
            }
            else if (dividend < 0 && divisor > 0)
            {
                while (dividend <= -divisor)
                {
                    dividend += divisor;
                    i--;
                }
            }
            return i;
        }
    }
}

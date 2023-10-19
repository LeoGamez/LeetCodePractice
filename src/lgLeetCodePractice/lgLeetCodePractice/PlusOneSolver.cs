using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lgLeetCodePractice
{
    public class PlusOneSolver
    {
        public int[] PlusOne(int[] digits)
        {
            if (digits.Length == 1 && digits[0] == 9)
            {
                return new int[] { 1, 0 };
            }
            int current = digits.Length - 1;
            int carry = 1;
            while (current >= 0 && carry > 0)
            {
                digits[current] = digits[current] + carry;
                if (digits[current] > 9)
                {
                    carry = 1;
                    digits[current] = 0;
                }
                else
                {
                    carry = 0;
                }
                current--;
            }

            if (carry > 0)
            {
                digits = digits.Reverse().ToArray();
                digits = digits.Append(carry).ToArray();
                digits = digits.Reverse().ToArray();
            }

            return digits;
        }
    }
}

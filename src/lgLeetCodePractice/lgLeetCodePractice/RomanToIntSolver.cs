using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lgLeetCodePractice
{
    public class RomanToIntSolver
    {
        public int RomanToInt(string s)
        {
            string current = s;
            int result = 0;
            int i = 0;
            var roman = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I", };
            var limits = new int[] { 3000,900,500,400,300,90,50,40,30,9,5,4,3};
            var steps = new int[] { 1000,900,500,400,100,90,50,40,10,9,5,4,1};
            int acc = 0;
            while (current.Length > 0 && i < roman.Length)
            {
                if (acc < limits[i] && current.StartsWith(roman[i]))
                {
                    current = current.Substring(roman[i].Length);
                    result += steps[i];
                    acc += steps[i];
                }
                else
                {
                    acc = 0;
                    i++;
                }
            }

            return result;
        }
    }

}


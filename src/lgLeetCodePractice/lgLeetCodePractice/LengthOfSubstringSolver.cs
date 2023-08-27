using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lgLeetCodePractice
{
    public class LengthOfSubstringSolver
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            if (s.Length <= 1)
            {
                return s.Length;
            }
            int left = 0;
            int right = 1;
            int maxLength = 1;
            string current = s[0].ToString();
            Console.WriteLine($"INPUT={s}");

            while (right < s.Length)
            {
                current = s[left..(right)];
                var letterAdded = s[right];

                if (current.Contains(letterAdded))
                {
                    left++;
                }
                else
                {
                    if (current.Length + 1 > maxLength)
                    {
                        maxLength = current.Length+1;
                    }
                    right++;
                }
               

                Console.WriteLine($"{current}- left:{left},right:{right}-max:{maxLength}-letterAdd:{letterAdded}");
            }

            return maxLength;
        }
    }
}

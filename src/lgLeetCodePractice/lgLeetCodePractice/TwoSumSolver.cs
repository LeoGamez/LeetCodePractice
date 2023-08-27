using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lgLeetCodePractice
{
    public class TwoSumSolver
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            int delta = target;
            int[]sorted=nums.ToArray();
            Array.Sort(sorted);
            while(left < right)
            {
                int current = sorted[left] + sorted[right]-target;

                if (current > 0)
                {
                    right--;
                }
                else if (current < 0)
                {
                    left++;
                }
                else
                {
                    int first = Array.IndexOf(nums, sorted[left]);
                    int second= Array.IndexOf(nums, sorted[right]);
                    while(first==second)
                    {
                        second = Array.IndexOf(nums, sorted[right],first+1);
                    }
                    return new int[] { first, second };
                }
            }

            return new List<int>().ToArray();
        }
    }
}

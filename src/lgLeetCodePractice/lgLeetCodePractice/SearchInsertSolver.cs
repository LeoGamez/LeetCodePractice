using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lgLeetCodePractice
{
    public class SearchInsertSolver
    {
        public int SearchInsert(int[] nums, int target)
        {
            int ix = 0;
            while (nums[ix] < target && ix<nums.Length-1)
            {
                 ix++;
            }

            if (target - nums[ix] > 0)
            {
                ix++;
            }

            return ix;
        }
    }
}

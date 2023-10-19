using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lgLeetCodePractice
{
    public class RemoveElementSolver
    {
        public int RemoveElement(ref int[] nums, int val)
        {
            int initial = nums.Length;
            nums = Array.FindAll(nums, n=>n!=val).ToArray();
            return initial - nums.Length;
        }
    }
}

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lgLeetCodePractice
{
    public class RemoveDuplicatesSolver
    {
        public int RemoveDuplicates(ref int[] nums)
        {
            var set = new HashSet<int>(nums);
            
            for(int i=0; i< set.Count; i++)
            {
                nums[i] = set.ElementAt(i);
            }
            return set.Count;
        }


    }
}

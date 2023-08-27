using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lgLeetCodePractice
{
    public class FindMedianSortedArraysSolver
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1 == null || nums2 == null)
            {
                return 0;
            }
            if (nums1.Length == 0 && nums2.Length == 0)
            {
                return 0;
            }
            else if (nums1?.Length == 0)
            {
                nums1 = nums2;
            }
            else 
            {
                nums1=nums1.Concat(nums2).ToArray();
            }

            Array.Sort(nums1);
            var ix = (nums1.Length/ 2);
            return  nums1.Length % 2 == 0 ? (double)(nums1[ix] + nums1[ix - 1]) / 2 : nums1[ix];
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.TwoSum.Tasks
{
    public class TwoSum
    {
        public int[] TwoSums(int[] nums, int target)
        {
            int[] list = new int[2];

            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++) 
                {
                    if (nums[i] + nums[j] == target)
                    {
                        list[0] = i;
                        list[1] = j;
                        return list;
                    }
                }
            }

            return list;
        }
    }
}

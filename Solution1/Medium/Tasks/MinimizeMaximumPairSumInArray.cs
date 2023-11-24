using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Tasks
{
    public class MinimizeMaximumPairSumInArray
    {
        public int MinPairSum(int[] nums)
        {
            int maxSum = 0;
            Array.Sort(nums);
            for(int i = 0; i < nums.Length/2; i++)
            {
                int sum = nums[i] + nums[nums.Length - i - 1];
                maxSum = Math.Max(maxSum, sum);
            }

            return maxSum;
        }
    }
}

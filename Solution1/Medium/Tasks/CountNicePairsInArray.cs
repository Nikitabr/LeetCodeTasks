using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Tasks
{
    public class CountNicePairsInArray
    {
        public int CountNicePairs(int[] nums)
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                int temporaryNumber = num - Reverse(num);

                if (numbers.ContainsKey(temporaryNumber))
                {
                    numbers[temporaryNumber]++;
                }
                else
                {
                    numbers[temporaryNumber] = 1;
                }
            }

            long result = 0;
            int mod = 1000000007;
            foreach (int value in numbers.Values)
            {
                result = (result % mod + ((long)value * ((long)value - 1) / 2)) % mod;
            }


            return (int)result;
        }

        public int Reverse(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }

            return rev;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Tasks
{
    public class DiagonalTraverseII
    {
        public int[] FindDiagonalOrder(IList<IList<int>> nums)
        {
            // (sum of row and column, row num, value)
            IList<(int, int ,int)> tuples = new List<(int, int ,int)>();

            for(int i = 0; i < nums.Count; i++)
            {
                for(int j = 0; j < nums[i].Count; j++)
                {
                    tuples.Add((i + j, i, nums[i][j]));
                }
            }

            (int, int, int)[] sortedNums = tuples.ToArray<(int, int, int)>();
            Array.Sort(sortedNums);

            int[] res = new int[tuples.Count];

            for(int i = 0; i < tuples.Count; i++)
            {
                res[i] = tuples[i].Item3;
            }

            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ProgrammingProblems.LeetCode
{
    public class TwoSum
    {
        // https://leetcode.com/problems/two-sum/#/description
        public List<int> Solution(List<int> nums, int target)
        {
            for (var i = 0; i < nums.Count; i++)
            {
                for(var j = i + 1; j < nums.Count; j++)
                {
                    if (nums[i] + nums[j] == 9)
                    {
                        return new List<int> {i, j};
                    }
                }
            }

            throw new Exception("error");
        }
    }
}

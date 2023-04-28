using System;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace TwoSum
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Given an array of integers nuns and an integer target, return indices of the two numbers such that they add up to target'
            You may assume that each input would have exactly one solution.and you may not use the same element twice.
            You can return the answer in any order.

            Example 1
            Input: nums = [2,7,11,15], target = 9
            Output: [0,1]
            Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

            Constraints:

            2 <= nums.length <= 10^4
            * -10^9 <= nums[i] <= 10^9
            * -10^9 <= target <= 10^9
            * Only one valid answer exists.
            
            */
        }
        public int[] TwoSum(int[] nums, int target)
        {

            for (int x = 0; x < nums.Length; x++)
            {
                int remainder = target - nums[x];

                for (int y = x + 1; y < nums.Length; y++)
                {
                    if (nums[y] == remainder)
                    {
                        return new int[] { x, y };
                    }
                }
            }
            throw new ArgumentException("The sum of any two digits in the list is not the same as the target number!");
        }
    }
}

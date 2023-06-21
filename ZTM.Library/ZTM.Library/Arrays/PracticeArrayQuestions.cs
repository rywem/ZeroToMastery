using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZTM.Library.Arrays
{
    public class PracticeArrayQuestions
    {
        public int[] TwoSum(int[] nums, int target)
        {
            /*
             * Given an array of integers nums and an integer target, 
             * return indices of the two numbers such that they add 
             * up to target. You may assume that each input would have 
             * exactly one solution, and you may not use the same element 
             * twice. You can return the answer in any order.
             */
            Dictionary<int ,int> compliments = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int current = nums[i];

                int compliment = target - nums[i];
                int value = 0;
                if(compliments.TryGetValue(current, out value))
                {
                    return new[] { value, i };
                }
                compliments.TryAdd(compliment, i);
            }

            return new int[0];
        }

        public int MaxSubArray(int[] nums)
        {
            int maxSub = nums[0];
            int curSum = 0;

            foreach (int n in nums)
            {
                if (curSum < 0)
                    curSum = 0;

                curSum += n;
                if(curSum > maxSub)
                    maxSub = curSum;
                
            }

            return maxSub;
        }

        //similar to quicksort
        public int[] MoveZeroes(int[] nums)
        {
            int leftPointer = 0;
            int rightPointer = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int temp;
                if (nums[i] != 0)
                {
                    temp = nums[leftPointer];
                    nums[leftPointer] = nums[rightPointer];
                    nums[rightPointer] = temp;
                    leftPointer++;

                }
                rightPointer++;
            }
            return nums;
        }
    }
}

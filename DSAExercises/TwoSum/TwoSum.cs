using System;
using System.Collections.Generic;

namespace DSAExercises
{
    public class TwoSum
    {
        public static int[] FindTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map[nums[i]] = i;
            }
            return null;
        }

        public static void Main(string[] args)
        {
            int[] array = new int[] { 1, 7, 11, 2 };
            int target = 9;

            int[] result = FindTwoSum(array, target);

            Console.WriteLine(
                result != null
                    ? $"For given Array: [{string.Join(", ", array)}], Target: {target}, Result (Indices) for TwoSum: [{result[0]}, {result[1]}]"
                    : $"For given Array: [{string.Join(", ", array)}], Target: {target}, No solution found."
            );

        }
    }
}
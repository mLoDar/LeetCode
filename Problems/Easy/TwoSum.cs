namespace LeetCode.Problems.Easy
{
    internal class TwoSum
    {
        internal static int[] Solution(int[] nums, int target)
        {
            int[] output = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target && j != i)
                    {
                        output[0] = i;
                        output[1] = j;

                        break;
                    }
                }
            }

            return output;
        }
    }
}
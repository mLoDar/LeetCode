using System.Numerics;

namespace LeetCode.Problems.Easy.PlusOne
{
    internal class PlusOne
    {
        internal static int[] Solution(int[] digits)
        {
            var strNum = BigInteger.Parse(string.Join("", digits)) + 1;

            int[] output = new int[strNum.ToString().Length];

            for (int i = 0; i < strNum.ToString().Length; i++)
            {
                output[i] = Convert.ToInt32(strNum.ToString().Substring(i, 1));
            }

            return output;
        }
    }
}
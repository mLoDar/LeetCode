namespace LeetCode.Problems.Easy.MySqrt
{
    internal class MySqrt
    {
        internal static int Solution(int x)
        {
            double squareRoot = Math.Sqrt(x);
            string searchedNum = Convert.ToString(squareRoot).Split('.')[0];

            return Convert.ToInt32(searchedNum);
        }
    }
}
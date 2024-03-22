namespace LeetCode.Problems.Easy.PalindromeNumber
{
    internal class PalindromeNumber
    {
        internal static bool Solution1(int x)
        {
            string convertedX = Convert.ToString(x);

            string firstHalf = convertedX.Substring(0, convertedX.Length / 2);
            string secondHalf = string.Empty;

            if (convertedX.Length % 2 == 0)
            {
                secondHalf = convertedX.Substring(convertedX.Length / 2, convertedX.Length / 2);
            }
            else
            {
                secondHalf = convertedX.Substring(convertedX.Length / 2 + 1, convertedX.Length / 2);
            }

            secondHalf = string.Join("", secondHalf.ToArray().Reverse());

            if (firstHalf.Equals(secondHalf))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
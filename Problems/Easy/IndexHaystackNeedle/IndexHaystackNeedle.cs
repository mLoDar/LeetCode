namespace LeetCode.Problems.Easy.IndexHaystackNeedle
{
    internal class IndexHaystackNeedle
    {
        internal static int Solution(string haystack, string needle)
        {
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack.Substring(i, needle.Length).Equals(needle))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
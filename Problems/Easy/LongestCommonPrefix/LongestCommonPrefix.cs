namespace LeetCode.Problems.Easy.LongestCommonPrefix
{
    internal class LongestCommonPrefix
    {
        internal static string Solution(string[] strs)
        {
            string commonPrefix = string.Empty;

            string currentLetter = string.Empty;

            int letterIndex = 0;

            while (true)
            {
                // Loop through words in array
                for (int i = 0; i < strs.Length; i++)
                {
                    if (strs[i].Length <= 0 || letterIndex >= strs[i].Length)
                    {
                        return commonPrefix;
                    }

                    if (i == 0)
                    {
                        currentLetter = strs[i].Substring(letterIndex, 1);
                        continue;
                    }

                    if (strs[i].Substring(letterIndex, 1).Equals(currentLetter) == false)
                    {
                        return commonPrefix;
                    }
                }

                commonPrefix += currentLetter;
                letterIndex++;
            }
        }
    }
}
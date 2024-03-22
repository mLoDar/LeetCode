namespace LeetCode.Problems.Easy.RomanToInteger
{
    internal class RomanToInteger
    {
        internal static int Solution1(string s)
        {
            int finalNumber = 0;

            Dictionary<string, int> symbolValues = new()
            {
                {"I", 1 },
                {"IV", 4 },
                {"V", 5 },
                {"IX", 9 },
                {"X", 10 },
                {"XL", 40 },
                {"L", 50 },
                {"XC", 90 },
                {"C", 100 },
                {"CD", 400 },
                {"D", 500 },
                {"CM", 900 },
                {"M", 1000 }
            };

            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length)
                {
                    if (symbolValues.ContainsKey(s.Substring(i, 2)))
                    {
                        finalNumber += symbolValues[s.Substring(i, 2)];
                        i++;
                        continue;
                    }
                }

                finalNumber += symbolValues[s.Substring(i, 1)];
            }

            return finalNumber;
        }
    }
}
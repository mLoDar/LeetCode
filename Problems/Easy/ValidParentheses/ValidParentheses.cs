namespace LeetCode.Problems.Easy.ValidParentheses
{
    internal class ValidParentheses
    {
        internal static bool Solution(string s)
        {
            string openedParentheses = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                bool opened = false;

                switch (s[i])
                {
                    case '(':
                        openedParentheses = ')' + openedParentheses;
                        opened = true;
                        break;

                    case '{':
                        openedParentheses = '}' + openedParentheses;
                        opened = true;
                        break;

                    case '[':
                        openedParentheses = ']' + openedParentheses;
                        opened = true;
                        break;
                }

                if (openedParentheses.Length < 0 || opened == true)
                {
                    continue;
                }

                if (openedParentheses.Length > 0 && s[i].Equals(openedParentheses.First()))
                {
                    openedParentheses = openedParentheses.Remove(0, 1);
                }
                else
                {
                    return false;
                }
            }

            if (openedParentheses.Length > 0)
            {
                return false;
            }

            return true;
        }
    }
}
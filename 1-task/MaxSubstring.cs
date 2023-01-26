
namespace _1_task
{
    static class MaxSubstring
    {
        public static string str;
        public static string NormalizationString(string str)
        {
            return str = str.ToLower();
        }
        public static int SearchMaxSubstring(char[] str)
        {
            int maxSubstring = -1;
            int tmp = 1;
            for (int i = 1; i < str.Length; i++)
            {
                if ((str[i - 1] == str[i]))
                {
                    tmp += 1;
                }
                else
                {
                    if (tmp > maxSubstring) maxSubstring = tmp;
                    tmp = 1;
                }
            }

            return (tmp > maxSubstring ? tmp : maxSubstring);
        }
    }
}

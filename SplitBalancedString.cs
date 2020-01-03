namespace Problems
{
    public class SplitBalancedString
    {
        public static int BalancedStringSplit(string s)
        {
            int balance = 0;
            int answer = 0;
            char[] letters = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (letters[i] == 'L')
                {
                    balance++;
                }
                else
                {
                    balance--;
                }
                if (balance == 0)
                {
                    answer++;
                }

            }

            return answer;
        }
    }
}
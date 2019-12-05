using System;

namespace Problems
{
    public class SplitBalancedString
    {
        public int BalancedStringSplit(string s)
        {
            // declare balance and answer counter
            int balance = 0;
            int answer = 0;
            //convert string to array of char
            char[] letters = s.ToCharArray();
            // loop
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
namespace Problems
{
    public class JewelsAndStones
    {
        public int CompareOneJewelToStones(char jewel, string S)
        {
            char[] stones = S.ToCharArray();
            int myJewels = 0;
            int i = 0;
            while (i < stones.Length)
            {
                if (jewel == stones[i])
                    myJewels++;
                i++;

            }
            return myJewels;
        }
        public int NumJewelsInStones(string J, string S)
        {
            char[] jewels = J.ToCharArray();
            int myJewels = 0;
            int i = 0;
            while (i < jewels.Length)
            {
                int result = CompareOneJewelToStones(jewels[i], S);
                myJewels = myJewels + result;
                i++;

            }
            return myJewels;

        }

        /*
        public int NumJewelsInStones(string J, string S)
        {
            char[] stones = S.ToCharArray();
            char[] jewels = J.ToCharArray();
            int myJewels = 0;
            int i = 0;
            while (i < S.Length)
            {
                foreach (char jewel in jewels)
                {
                    if (jewel == stones[i])
                        myJewels++;

                }
                i++;
            }
            return myJewels;
        }*/
    }
}
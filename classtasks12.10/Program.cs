namespace classtasks12._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string word = "  Hikmet  Abbasov  ";
            //RemoveEmpty(ref word);
            //Console.WriteLine(word);
            //Console.WriteLine(CountOdd(2,9));

        }

        private static string RemoveEmpty(ref string word)
        {
            string newWord = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ') newWord += word[i];

            }
            word = newWord;
            return word;
        }

        public static int CountOdd(int n, int m)
        {
         
            int count = default;
            for (int i = n; i < m; i++)
            {
                if (i % 2 != 0) count++;
            }
            return count;
        }

    }
}

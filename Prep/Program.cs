using System;

namespace Prep
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string s = "madam";

            //int i = 0;
            //int j = s.Length - 1;


            for (int i = 0; i <= s.Length -1; i++)
            {
                for (int j = s.Length - 1; j >= 0; j--)
                {
                    if (s[i] != s[j])
                    {
                        Console.WriteLine("String is not a palindrome");
                        return;
                    }

                    if (s[i] > s[j])
                    {
                        Console.WriteLine(s[i] + "::::" + s[j] + "string is palindrome");
                        return;
                    }
                }
                Console.WriteLine(s[i]);
            }
        }
    }

    public class Node
    {
        public int Data;
        public Node Left;
        public Node Right;
        public void DisplayNode()
        {
            Console.Write(Data + " ");
        }
    }
}

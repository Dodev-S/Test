using System;
using System.Linq;

class Problem9
{
    static void Main()
    {
        for (int i3 = 0; i3 < 8; i3++)
        {
            Console.WriteLine("Enter some text:");
            string[] userInput = Console.ReadLine().Split(' ').ToArray();
            string url1 = "http://";
            string url2 = "www.";

            foreach (string word in userInput)
            {
                if (word.Contains(url1) || word.Contains(url2))
                {
                    Console.WriteLine(word.Trim('.'));
                }
            }
        }
    }
}


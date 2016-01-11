using System;
using System.Linq;

class Problem8
{
    static void Main()
    {
        for (int i5 = 0; i5 < 8; i5++)
        {
            Console.WriteLine("Enter some text:");
            string[] userInput = Console.ReadLine().Split(' ').ToArray();
            int longest = 0;
            string result = "";
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i].Count() > longest)
                {
                    longest = userInput[i].Count();
                    result = userInput[i];
                }
            }
            Console.WriteLine(result);

        }
    }
}


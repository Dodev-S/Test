using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem2
{
    static void Main()
    {
        for (int i5 = 0; i5 < 8; i5++)
        {
            Console.WriteLine("Enter an integer n=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter {0} integers each on a new line", n);
            int[] userInput = new int[n];

            for (int i = 0; i < n; i++)
            {
                userInput[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(userInput);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(userInput[i]);
            }
        }
    }
}


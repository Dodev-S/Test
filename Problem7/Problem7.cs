using System;
using System.Collections.Generic;
using System.Linq;

class Problem7
{
    static void Main()
    {
        for (int i5 = 0; i5 < 8; i5++)
        {
            Console.WriteLine("Enter several integers separated by a space:");
            List<int> userInput0 = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();
            Console.WriteLine("Enter several integers separated by a space:");
            List<int> userInput1 = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToList();
            userInput0.AddRange(userInput1);
            List<int> result = userInput0.Distinct().ToList();
            result.Sort();

            foreach (int element in result)
            {
                Console.Write("{0} ", element);
            }

        }
    }
}


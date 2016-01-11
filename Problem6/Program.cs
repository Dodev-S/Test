using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        for (int i3 = 0; i3 < 8; i3++)
        {
            Console.WriteLine("Enter names separated by a space:");
            List<string> userInput = Console.ReadLine().Split(' ').ToList();
            Console.WriteLine("Enter names separated by a space:");
            List<string> userInput1 = Console.ReadLine().Split(' ').ToList();

            foreach (string name in userInput1)
            {
                while (userInput.Contains(name))
                {
                    userInput.Remove(name);
                }
                    
            }
                foreach (string item in userInput)
                {
                    Console.WriteLine("{0} ", item);
                }
        }
    }
}


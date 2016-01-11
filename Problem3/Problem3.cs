using System;

class Problem3
{
    static void Main()
    {
        for (int i5 = 0; i5 < 8; i5++)
        {
            Console.WriteLine("n=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter {0} strings each on a separate line:", n);
            string[] userInput = new string[n];
            int currentCounter = 1;
            int totalCounter = 1;
            for (int i = 0; i < n; i++)
            {
                userInput[i] = Console.ReadLine();
            }
            string result = userInput[0];

            for (int i2 = 0; i2 < n - 1; i2++)
            {
                if (userInput[i2] == userInput[i2+1])
                {
                    currentCounter++;
                    if (currentCounter>totalCounter)
                    {
                        totalCounter = currentCounter;
                        result = userInput[i2];
                    }
                }
                else
                {
                    currentCounter = 1;
                }
            }
            Console.WriteLine(totalCounter);
            for (int i3 = 0; i3 < totalCounter; i3++)
            {
                Console.WriteLine(result);
            }
        }
    }
}
 

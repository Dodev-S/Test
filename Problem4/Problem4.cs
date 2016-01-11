using System;

class Problem4
{
    static void Main()
    {
        for (int i5 = 0; i5 < 8; i5++)
        {
            Console.WriteLine("r=");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("c=");
            int c = int.Parse(Console.ReadLine());
            string palindrone = new string('a', 1);

            for (int i = 0; i < r; i++)
            {
                palindrone = new string(((char)('a' + i)), 3);
                for (int i1 = 0; i1 < c; i1++)
                {
                    string replacement = ((char)('a' + i + i1)).ToString();
                    string palindrongeEdited = palindrone.Remove(1, 1).Insert(1, replacement);
                    Console.Write("{0,5} ", palindrongeEdited);
                }
                Console.WriteLine();
            }
        }
    }
}


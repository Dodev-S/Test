using System;

class Problem1
{
    static void Main()
    {
        for (int i = 0; i < 8; i++)
        {
            //Console.WriteLine("Enter a date in format dd.MM.yyyy:");
            //string format = "dd.MM.yyyy";
            //DateTime firstDate = DateTime.ParseExact(Console.ReadLine(), format, null);
            //Console.WriteLine("Another date in format dd.MM.yyyyy:");
            //DateTime secondDate = DateTime.ParseExact(Console.ReadLine(), format, null);
            //Console.WriteLine((firstDate - secondDate).Days);

            DateTime wow = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(wow);

        }
    }
}


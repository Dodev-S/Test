using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5
{
    class Problem5
    {
        static void Main(string[] args)
        {
            for (int i3 = 0; i3 < 8; i3++)
            {
                // taq zada4a stana leshta i e s oburkano uslovie/priemri, i zatova q zaebavam
                // dotuk. 

                Console.WriteLine("Enter several integers separated by a space:");
               
                int[] userArray = Console.ReadLine().Split(' ').Select(s=> int.Parse(s)).ToArray();
                List<int> result = new List<int>();
                result.Add(userArray[0]);
                List<int> finalResult = new List<int>();
                finalResult.Add(result[0]);
                for (int i = 1; i < userArray.Length; i++)
                {
                    if (userArray[i] >= userArray[i-1])
                    {
                        result.Add(userArray[i]);
                        
                        if (result.Count > finalResult.Count && userArray[i] > userArray[i+1])
                        {
                            finalResult.Clear();
                            foreach (var item in result)
                            {
                                finalResult.Add(item);
                            }
                            result.Clear();
                        }
                    }

                }
                foreach (var item in finalResult)
                {
                    Console.Write("{0} ", item);
                }

            }
        }
    }
}

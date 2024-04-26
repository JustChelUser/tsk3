using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] simpleNumbers3(int[] numbers)
            {
                int min = numbers[0];
                int max = numbers[1];
                List<int> simpleNumbers = new List<int>();
                for (int i = min; i <= max; i++)
                {
                    bool simpleNumber = true;
                    if (i > 1)
                    {
                        int sqr = (int)Math.Sqrt(i);
                        for (int j = 2; j <= sqr; j++)
                        {
                            if (i % j == 0)
                            {
                                simpleNumber = false;
                                break;
                            }
                        }
                        if (simpleNumber)
                        {
                            simpleNumbers.Add(i);

                        }
                    }
                }
                return simpleNumbers.ToArray();
            }
            string numbersOriginal = Console.ReadLine();
            string[] numbersString = numbersOriginal.Split(',');
            int[] numbersInt = Array.ConvertAll(numbersString, Int32.Parse);
            int[] testData = { 11, 20};
            int[] resultArray = simpleNumbers3(numbersInt);
            for (int i = 0; i < resultArray.Length; i++)
            {
                if (i + 1 != resultArray.Length)
                {
                    Console.Write(resultArray[i] + ",");
                }
                else
                {
                    Console.Write(resultArray[i]);

                }
            }
            Console.ReadLine();
        }
    }
}

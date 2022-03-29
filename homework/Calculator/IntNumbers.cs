using System;
using System.Linq;
namespace homework.Calculator
{
    public class IntNumbers
    {
        public IntNumbers()
            //static void Main(string[] args)
        {

            // int n = 10;
            //int[] strs = new int[n];

            // for (int i = -10; i < n; i++)
            // {
            //     int max = int.MinValue;
            //     for (int  = 0; i < strs.Length; i++)
            //     {
            //         if (strs[i] > max)
            //         {
            //             // найден больший элемент
            //             max = strs[i];
            //         }
            //     }
            // }
            Random rnd = new Random();
            int[] rndNumbers = new int[21];
            for (int i = 0; i < rndNumbers.Length; i++)
                rndNumbers[i] = rnd.Next(-10, 10);
            // int[] array = new int[] { -10,-9,-8,-7,-6,-5,-4,-3,-2,-1,0,1,2,3,4,5,6,7,8,9,10 };
            int maxValue = rndNumbers.Max();
            int minValue = rndNumbers.Min();
            Console.WriteLine(maxValue);
            Console.WriteLine(minValue);




            //int max = int.MinValue;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i] > max)
            //    {
            //        // найден больший элемент
            //        max = array[i];
            //        Console.WriteLine(max);
            //    }
            //}
        }
        }
    }


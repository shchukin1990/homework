using System;
namespace homework.Задачи2
{
    public class С_3_1
    {
        public С_3_1()
        //C3.1.Даны числа a1, a2, …, a10.Определить их сумму.


        //static void Main(string[] args)
        {
            int sum = 0;
            int[] numbers = { 1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 10 };
            for (int i = 0; i < 10; i++) 
            {
                sum += numbers[i];
                Console.WriteLine(sum);
            }
        }
    }
}

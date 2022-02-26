using System;
namespace homework.Задачи2
{
    public class С3_10
    {
        //public С3_10()
        static void Main(string[] args)
        {
            //C3.10.Даны числа a1, a2, …, a10. Определить сумму их квадратов.
            int h;
            int sum = 0;
            int[] numbers = { 1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 10 };
            for (int i = 0; i < 10; i++)
            {

                h = numbers[i] * numbers[i];
                sum += h;
            }
            Console.WriteLine(sum);
        }
    }
}

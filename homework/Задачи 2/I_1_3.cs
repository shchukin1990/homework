using System;
namespace homework.Задачи2
{
    public class I_1_3
    {
        //I1.3. Определить максимальное и минимальное значения из двух различных вещественных чисел.
        public I_1_3()
        //  static void Main(string[] args)
        {
            int x;
            int y;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(x, y));
            Console.WriteLine(Math.Min(x, y));
        }
    }
}


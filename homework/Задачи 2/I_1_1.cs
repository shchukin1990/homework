using System;
namespace homework.Задачи2
{
    public class I_1_1
    {
        //I1.1. Рассчитать значение у при заданном значении х: y=sin(x) при x>0 или y = cos(x) в противном случае.
        public I_1_1()
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y;
            if (x > 0)
            {
                y = Math.Sin(x);
                Console.WriteLine(y);
            }
            else
            {
                y = Math.Cos(x);
                Console.WriteLine(y);
            }
            Console.ReadKey();
        }
    }
}

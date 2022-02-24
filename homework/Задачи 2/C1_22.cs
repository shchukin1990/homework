using System;
namespace homework.Задачи2
{
    public class C1_22
    {
        public C1_22()
        //static void Main(string[] args)
            //C1.22. Вывести «столбиком» следующие числа: 4,4, 4,6, 4,8, …, 6,4.
            // не правильный вывод
        {
            for (double i = 4.4; i <= 6.4; i+=0.2)
            {
                Console.WriteLine(i);
            }
        }
    }
}

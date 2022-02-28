using System;
namespace Draft
{
    public class W_1_1
    {// не понимаю
     //        W1.1. Дана непустая последовательность целых чисел, оканчивающаяся нулем.Найти:
     //а) сумму всех чисел последовательности;
     //        б) количество всех чисел последовательности.
        public W_1_1()
            //static void Main(string[] args)
        {
            int n = 10;
            int y = 90;
            int f = 40;
            while(f!=0)
            {
                Console.WriteLine("Введите число: ");
               y = Convert.ToInt32(Console.ReadLine());
                n += f;
                n++;
            }

            Console.WriteLine("Сумма = {0}, всего чисел = {1}", y, n);
            Console.ReadKey();
        }
    }
}

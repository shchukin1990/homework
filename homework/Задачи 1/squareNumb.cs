using System;
namespace homework
{
    public class EmptyClass
    {
        //S2.2. Дана сторона квадрата.Найти его периметр.
        static void  mdglk(string[] args)
        {
            Console.WriteLine("Введите длины стороны квадрата: ");
            double r = Convert.ToInt32(Console.ReadLine());

            if (r > 0)
            {
                double p = r * 4;
                Console.Write(" Периметр квадрата = {0}.", p);

            }
            else
                Console.Write("Введено не верное значение.");
            Console.ReadKey();
        }
    }
}

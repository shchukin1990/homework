using System;
namespace homework
{
    public class squareNumb
    {
        //S2.2. Дана сторона квадрата.Найти его периметр.
        public static void square(string[] args)
        {
            Console.WriteLine("Введите длины стороны квадрата: ");
            double r = Convert.ToInt32(Console.ReadLine());
            // хотел написать еще try catch на то чтобы нельзя было ввести буквы


            //try
            //{
            //    r = Convert.ToInt32(Console.ReadLine());
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Вы ввели буквы, будьте впредь аккуратны");
            //}

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

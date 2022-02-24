using System;
namespace homework
{
    public class squareNumb
    {
        //S2.2. Дана сторона квадрата.Найти его периметр.
        public static void fhfhh(string[] args)
        {
            
            double r = 0;
            // хотел написать еще try catch на то чтобы нельзя было ввести буквы
            do
            {


                try
                {
                    Console.WriteLine("Введите длины стороны квадрата: ");
                    r = Convert.ToInt32(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели буквы, будьте впредь аккуратны");
                }
            }
            while (r == 0);


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

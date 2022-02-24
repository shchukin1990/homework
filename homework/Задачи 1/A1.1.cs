using System;
namespace homework
{
    public class A1
    {
        //static void Main(string[] args)
            static void fhhfh(string[] args)
        {
            //A1.1.Дано расстояние в сантиметрах.Найти число полных метров в нем.
            Console.WriteLine("Укажите расстояние в сантиметрах ");
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double s) && s > 0)
                {
                    double m = s / 100d;
                    Console.WriteLine($"число полных метров в {s} см. равно {m} m. ");
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели не правильное число");
                }
            }
        }
    }
}

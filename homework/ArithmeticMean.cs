using System;
namespace homework
{
    public class ArithmeticMean
    {

        // S2.7. Даны два целых числа. Найти: а) их среднее арифметическое; б) их среднее геометрическое.
        //public ArithmeticMean()
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа ");
            double g = int.Parse(Console.ReadLine());
            double t = int.Parse(Console.ReadLine());
            double averageAr = (g + t) / 2;
            double averageGeometry = Math.Sqrt(g * t);
            Console.WriteLine(averageAr);
            Console.WriteLine(averageGeometry);
        }
    }
}

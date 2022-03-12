using System;
namespace homework
{
    public class I_3_5
    {
        //public I_3_5()
            static void Main(string[] args)
        {
            // I3.5.Даны три вещественных числа a, b, c.
            //Определить, имеется ли среди них хотя бы одна пара равных между собой чисел.
            Console.WriteLine("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if(a==b||b==c||c==a)
            {
                Console.WriteLine("Числа равны между собой");
            }
            else
            {
                Console.WriteLine("Числа не равны");
            }
        }
    }
}

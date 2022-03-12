using System;
namespace homework.Задачи3
{
    public class I3_1
    {
        //public I3_1()
            static void Main(string[] args)
        {
            //I3.1.Проверить, принадлежит ли число, введенное с клавиатуры, интервалу(–5, 3).
            Console.WriteLine("Введите число: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a > -5 && a < 3)
            {
                // a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("правильно");



            }
            else
            {
                Console.WriteLine("нет");
            }
        }
    }
}

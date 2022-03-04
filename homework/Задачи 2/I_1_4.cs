using System;
namespace homework.Задачи2
{
    public class I_1_4

    {
        public void I_1_1()
        //I1.4. Известны два расстояния: одно в километрах, другое — в футах(1 фут 0,305 м). Какое из расстояний меньше?


         //public static void Main(string[] args)
        {

            Console.Write("Введите первое расстояние в км : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Введите второе расстояние в футах (1 фут = 0.305м) : ");// 1 фут = 0.305м
            double b = double.Parse(Console.ReadLine());
            double am = a * 1000;
            double bm = b * 0.305;//переводим в метры
            if (am > bm)
                Console.WriteLine(a + "км больше " + b + "футов");
            if (am < bm)
                Console.WriteLine(a + "км меньше " + b + "футов");
            if (am == bm)
                Console.WriteLine(a + "км равен " + b + "футов");
            Console.ReadLine();
     }   }
}

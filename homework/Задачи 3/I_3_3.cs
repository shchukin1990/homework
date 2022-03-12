using System;
namespace homework
{
    public class I_3_3
    {
        public I_3_3()
            //static void Main(string[] args)
        {
            //I3.3.Определить, является ли число а делителем числа b или, наоборот, число b делителем числа а.
            //    Ответом должны служить сообщения «Да, одно из чисел является делителем другого» или «Нет, ни одно из чисел не является делителем другого».
            Console.WriteLine("Введите число а");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число  b");
            int b = int.Parse(Console.ReadLine());
            if (b / a == 0 || a / b == 0)
                Console.WriteLine("Да, одно из чисел является делителем другого");
             else
                Console.WriteLine("Нет, ни одно из чисел не является делителем другого");
            //не попадает в блок   else

        }
    }
}

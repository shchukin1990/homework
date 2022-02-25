using System;
namespace homework.Задачи2
{
    public class C2_2_a
    {
        public C2_2_a()
//        C2.2. Найти:
//а) произведение всех целых чисел от 8 до 15;
            //static void Main(string[] args)
        {
            
            int r = 1;
            for (int a = 8; a <= 15; a++)
                r *= a;
            Console.WriteLine(r);
            
        }
    }
}

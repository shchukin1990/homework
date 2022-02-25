using System;
namespace homework.Задачи2
{
    public class С2_4
    {
        static void Main(string[] args)
        {
            int c = 0;
            for (int i = 20; i <= 40; i++)
            {
                c += i * i * i;
                Console.WriteLine(+c);
            }
        }
    }
}

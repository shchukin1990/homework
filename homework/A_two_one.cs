using System;
namespace homework
{
    public class A_two_one
    {
        //public A_two_one()
            static void Main(string[] args)
        {
            //A2.1.Дано двузначное число. Найти:
            //а) число десятков в нем;
            //б) число единиц в нем;
            //в) сумму его цифр;
            //г) произведение его цифр.
            int dozens;
            int units;
            int sum;
            Console.WriteLine("x=");
            int x = int.Parse(Console.ReadLine());
            dozens = x / 10;
            units = x - (dozens * 10);
            Console.WriteLine($"Количество десятков {dozens:f0}");
            Console.WriteLine($"Количество единиц {units:f0}");
            sum = dozens + units;
            Console.WriteLine($"Сумма всех чисел двузначного числа {sum:f0}");
        }
    }
}

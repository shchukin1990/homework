using System;
namespace homework
{
    public class AThreeFour
    {
        //public AThreeFour()
       // A3.4. В трехзначном числе x зачеркнули первую цифру.
       // Когда полученное число умножили на 10
       // , а произведение сложили с первой цифрой числа x,
       // то получилось число n.По заданному n найти число x
       // (значение n вводится с клавиатуры, 100 ≤ n ≤ 999).
            static void Main(string[] args)
        {
            int n;
            
            int buf;
            int buf1;
            int number;

            Console.WriteLine("Введите число от 1 до 999");
            n = int.Parse(Console.ReadLine());
            while((n>999)|(n<1))
            {
                Console.WriteLine("Введите число от 1 до 999");
                n = int.Parse(Console.ReadLine());
            }
            buf = n / 10;
            buf1 = (n - buf * 10);
            number = buf1 * 100 + buf;
            Console.WriteLine("Число x = {0}", number);
        }
    }
}

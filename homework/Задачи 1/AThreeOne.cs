using System;
namespace homework
{
    public class AThreeOne
    {
        public AThreeOne()
        //A3.1 Из трехзначного числа x вычли его последнюю цифру.
        //Когда результат разделили на 10, а к частному слева приписали
        //последнюю цифру числа x, то получилось число 237. Найти число x.


            //static void Main(string[] args)
        {
            int x, y, num, priv;
            y = 237;
            num = y / 100;
            priv = y % 100;
            x = priv * 10 + num;
            Console.WriteLine(x);
        }
    }
}

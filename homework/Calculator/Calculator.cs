using System;
namespace homework.Calculator
{
    public class Calculator2
    {
        //public Calculator2()
        static void Main(string[] args)
        {
            double firstValue;
            double secondValue;
            string action;
            //try
            //{
                Console.WriteLine("Введите число 1");
                firstValue = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите число 2");
                secondValue = double.Parse(Console.ReadLine());
            //}
            //catch(Exception)
            //{
            //    Console.WriteLine("Не удалось найти число");
            //    Console.ReadLine();
            //    //continue;
                
            //}
            Console.WriteLine("Выберете операцию: '+' '-' '*' '/'");
            action = Console.ReadLine();

            switch (action)
            {
                case "+":
                    Console.WriteLine(firstValue + secondValue);
                    break;
                case "-":
                    Console.WriteLine(firstValue - secondValue);
                    break;
                case "*":
                    Console.WriteLine(firstValue * secondValue);
                    break;
                case "/":
                    if (secondValue == 0)
                    {
                        Console.WriteLine("На ноль делить нельзя");
                    }
                    else
                    {
                        Console.WriteLine(firstValue / secondValue);
                    }

                    break;

                default:
                    Console.WriteLine("Ошибка неизвестное действие");
                    break;
            }
            Console.ReadLine();


        }
    }
}

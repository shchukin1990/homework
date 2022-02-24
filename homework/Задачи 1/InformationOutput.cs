using System;
namespace homework
{
    public class InformationOutput
    {
        /*S1.13 Составить программу вывода на экран следующей информации:
      2 кг
      13 17
      */
        static void Output(string[] args)
        {
            int v = 5;
            int d = 43;
            int k = 76;

            Console.WriteLine(v + "кг");
            Console.WriteLine($"{d} {k}");
            Console.ReadLine();

        }
    }
}

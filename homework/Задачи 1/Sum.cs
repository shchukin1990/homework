using System;
namespace homework
{
    public class Sum
    {
        //S2.23. Известна стоимость монитора, системного блока, клавиатуры и мыши.Сколько будут стоить 3 компьютера из этих элементов? N компьютеров?
        //static void Main(string[] args)
        static void SumOfComputer(string[] args)
        {
            double monitor = 100;
            double SystemBlock = 200;
            double KeyBoard = 30;
            Console.WriteLine(monitor+SystemBlock+KeyBoard);
        }
    }
}

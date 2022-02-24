using System;
namespace homework.Задачи2
{
    public class I_5_1
    {
        //I5.1. Составить программу, которая в зависимости от порядкового номера дня недели(1, 2, …, 7) выводит на экран его название(понедельник, вторник, …, воскресенье).
       public I_5_1()
            //static void Main(string[] args)
        {
            int Day_Of_Week = int.Parse(Console.ReadLine()) ;
            

            switch (Day_Of_Week)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine(" Вторник");
                    break;
                case 3:
                    Console.WriteLine(" Среда");
                    break;
                case 4:
                    Console.WriteLine(" Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
            }
        }
    }
}

using System;
namespace homework
{
    public class A_one_seven
    {
       public A_one_seven()
         //static void Main(string[] args)
        {
            //            A1.7.Дан прямоугольник с размерами 543 х 130 мм.Сколько квадратов со стороной 130 мм можно отрезать от него?
            //Я сделал решение задачи с вводимыми координатами где одна из сторон прямоугольника равна стороне квадрата. Все ли верно ?

            Console.WriteLine("Введите длину: ");
            int lenth = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину: ");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine(lenth / width);
        }
    }
}

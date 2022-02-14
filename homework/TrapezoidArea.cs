using System;
namespace homework
{
    public class TrapezoidArea
    {
        //S2.14. Даны основания и высота равнобедренной трапеции. Найти ее периметр.
        static void Main(string[] args)
        {
            double footing = 10;
        
            double high = 20;
            double perimetr = ((footing * 2) + (high * 2));
            Console.WriteLine(perimetr);
        }
    }
}

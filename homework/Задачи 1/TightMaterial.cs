using System;
namespace homework
{
    public class TightMaterial
    {
        //static void Main(string[] args)
       static void   density(string[]args)
        {
            //S2.8. Известны объем и масса тела. Определить плотность материала этого тела.

            double value = long.Parse(Console.ReadLine());
            double weight = long.Parse(Console.ReadLine());
            double density = weight / value;//desity- плотность 
            Console.WriteLine(density);

        }
    }
}

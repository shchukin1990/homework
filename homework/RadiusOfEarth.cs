using System;
namespace homework
{
    public class RadiusOfEarth
    {
        // S2.4. Считая, что Земля — идеальная сфера с радиусом R=6350 км, определить расстояние до линии горизонта от точки В с заданной высотой h = AB над Землей.
        static void Main(string[] args)
        {
            int r = 6350;
            int h = 1000;
            int hor = ((r + h) * (r + h)) - (r * r);
            Console.WriteLine("Расстояние до линии горизонта от точки В равна {0} км", hor);

        }
    }
}

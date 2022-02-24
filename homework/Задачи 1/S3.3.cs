using System;
namespace homework
{
    public class DoneNumbers
    {
//        S3.3. Дано вещественное число а.Пользуясь только операцией умножения, получить:
//а) a4 за две операции;
//        б) a6 за три операции;
//        в) a7 за четыре операции;
//        г) a8 за три операции;
//        д) a9 за четыре операции;
//        е) a10 за четыре операции.
        //static void Main(string[] args)
        static void fhhffh(string[] args)
        {
            int r;
               int a = 2;
            // а) a ^ 4 за две операции;
            r = a * a;
            r *= r;
            Console.WriteLine(r);
            // б) a ^ 6  за три операции;
            r = a * a;
            r = r * a;
            r *= r;
            Console.WriteLine(r);
            // в) a ^ 7 за четыре операции;
            r = a * a;
            r = r * a;
            r *= r;
            r = r * a;
            Console.WriteLine(r);
            // г) a ^ 8  за три операции;
            r = a * a;
            r *= r;
            r *= r;
            Console.WriteLine(r);
            // д) a ^ 9 за четыре операции;
            r = a * a;
            r *= r;
            r *= r;
            r = r * a;
            Console.WriteLine(r);
            // е) a ^ 10  за четыре операции.
            r = a * a;
            r *= r;
            r *= a;
            r = r * r;
            Console.WriteLine(r);
        }
    }
}

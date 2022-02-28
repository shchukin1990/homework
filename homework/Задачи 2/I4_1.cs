using System;
namespace Draft
{
    public class I4_1
    {
        //        I4.1. Даны два различных вещественных числа.Определить наибольшее из них, не используя полный условный оператор, а применив:
        //а) два неполных условных оператора;
        //        б) один неполный условный оператор.
        public I4_1()
            //static void Main(string[] args)
        {
            int n1 = 1;
             int n2 = 2;
            if (n1 > n2)
                Console.WriteLine(n1 + " больше");
            else
                Console.WriteLine(n2 + " больше");
        }
    }
}

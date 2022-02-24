using System;
namespace homework
{
    public class l_one_one
    {
        //        L1.1. Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
        //а) А или В; б) А и В; в) В или С.
        public l_one_one()
        //static void Main(string[] args)
        {
            bool A, B, C, X, Y, Z;
            A = true;
            B = false;
            C = false;
            X = A | B;
            Y = A & B;
            Z = B | C;
            Console.WriteLine($"{X}, {Y}, {Z}");
        }
    }
}

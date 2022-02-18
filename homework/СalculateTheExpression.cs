using System;
namespace homework
{
    public class СalculateTheExpression
    {
//        L1.5. Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
//а) А или В и не С; г) А и не В или С;
//        б) не А и не В; д) А и(не В или С);
//        в) не(А и С) или В; е) А или(не (В и С)).
        public СalculateTheExpression()
        //static void Main(string[] args)
        {
            bool A, B, C, Res;
            A = true;
            B = false;
            C = false;
            Res = A | B & !C;
            Console.WriteLine($"А) {Res}");
            Res = !A & !B;
            Console.WriteLine($"Б) {Res}");
            Res = !(A & C) | B;
            Console.WriteLine($"В) {Res}");
            Res = A & !B | C;
            Console.WriteLine($"Г) {Res}");
            Res = A & (!B | C);
            Console.WriteLine($"Д) {Res}");
            Res = A | !(B & C);
            Console.WriteLine($"Е) {Res}");
            Console.ReadKey();
        }
    }
}

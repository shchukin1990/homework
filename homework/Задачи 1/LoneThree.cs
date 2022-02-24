using System;
namespace homework
{
    public class LoneThree
    {
        public LoneThree()
            //static void Main(string[] args)
//            .Вычислить значение логического выражения при следующих значениях логических величин А, В и С: А = Истина, В = Ложь, С = Ложь:
//а) не А и В; б) А или не В; в) А и В или С.
        {


            bool X;
            
            bool Y;
            bool Z;
            bool result_A;
            bool result_B;
            bool result_C;
            X = true;
            Y = true;
            Z = false;
            result_A = !X && Y;
            result_B = X || !Y;
            result_C = X && Y || Z;
        }
    }
}

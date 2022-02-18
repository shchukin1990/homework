using System;
namespace homework
{
    public class l_one_eleven
    {
        public l_one_eleven()
            //static void Main(string[] args)
        {
            //            L1.11.Вычислить значение логического выражения при всех возможных значениях логических величин А и В:
            //а) не(А и В);
            //            б) не А или В;
            //            в) А или не В.
            Console.WriteLine("Выберите номер вариант: \n" +
       "а) не(А и В)\n" +
       "б) не А или В\n" +
       "в) А или не В");
            char LogicF = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("A\t" + "B\t" + "F(A,B)");
            bool[] AB = { false, true };
            bool F;
            foreach (bool a in AB)
                foreach (bool b in AB)
                {
                    switch (LogicF)
                    {
                        case 'а':
                            F = !(a && b);
                            break;
                        case 'б':
                            F = !a || b;
                            break;
                        case 'в':
                            F = a || !b;
                            break;
                        default:
                            F = false;
                            break;
                    }
                    Console.WriteLine(a + "\t" + b + "\t" + F);
                }

        }
    }
}

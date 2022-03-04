using System;
namespace homework.Задачи2
{
    public class I_5_7
    {
        public I_5_7()
            //static void Main(string[] args)
            //I5.7. Мастям игральных карт условно присвоены следующие порядковые номера: масти «пики» — 1, масти «трефы» — 2, масти «бубны» — 3, масти «червы» — 4, а достоинству карт: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14 (порядковые номера карт остальных достоинств соответствуют их названиям: «шестерка», «девятка» и т.п.). По заданным номеру масти m(1 <= m <= 4) и номеру достоинства карты k(6 <= k <= 14) определить полное название(масть и достоинство) соответствующей карты в виде «Дама пик», Шестерка бубен» и т.п.
        {
            int m, k;
            Console.WriteLine("Введите порядковый номер масти от (1 до 4)");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер достоинства карты (от 6 до 14)");
            k = int.Parse(Console.ReadLine());
            Console.Write("Ваша карта: ");
            switch (m)
            {
                case 1:
                    Console.Write("Пики ");
                    break;
                case 2:
                    Console.Write("Трефы ");
                    break;
                case 3:
                    Console.Write("Бубны ");
                    break;
                case 4:
                    Console.Write("Червы ");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            }
            switch (k)
            {
                case 6:
                    Console.Write("шестерка");
                    break;
                case 7:
                    Console.Write("семерка");
                    break;
                case 8:
                    Console.Write("восьмерка");
                    break;
                case 9:
                    Console.Write("девятка");
                    break;
                case 10:
                    Console.Write("десятка");
                    break;
                case 11:
                    Console.Write("валет");
                    break;
                case 12:
                    Console.Write("дама");
                    break;
                case 13:
                    Console.Write("король");
                    break;
                case 14:
                    Console.Write("туз");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            }
        }
    }
}

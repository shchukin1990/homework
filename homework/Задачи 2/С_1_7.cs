using System;
namespace homework.Задачи2
{
    public class С_1_7
    {
        public С_1_7()
        //static void Main(string[] args)
        {
            // C1.7.Одна штука некоторого товара стоит 55,99 руб.Напечатать таблицу стоимости 2, 3, …, 20 штук этого товара.
            for (int i = 1; i < 21; i++)
            {
                Console.WriteLine(i + "" + Convert.ToDouble(i*55.99));
            }
        }
    }
}

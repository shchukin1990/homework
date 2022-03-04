using System;
namespace homework.Задачи2
{
    public class C_3_3
    {
        public C_3_3()
         //static void Main(string[] args)
        {
            double amount = 0;

            double[] weight = { 43.5, 54, 6.76, 5.87, 98.3, 12.4, 43.5, 36.6, 43.6, 353.7, 242, 90 };

            for (int i = 0; i < 12; i++)
            {
                amount += weight[i];
            }
        }

    }
}


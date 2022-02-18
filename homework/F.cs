using System;
namespace homework
{
    public class F
    {
        //M1.1. Заполнить массив из восьми элементов следующими значениями: первый элемент массива равен 37, второй — 0, третий — 50, четвертый — 46, пятый — 34, шестой — 46, седьмой — 0, восьмой —13.
        //static void Main(string[] args)
        static void fhfhgjj(string[] args)
        {
            int[] newArr = new int[8] { 5,4,6,6,8,8,9,9};
            newArr[0] = 37;
            newArr[1] = 0;
            newArr[2] = 50;
            newArr[3] = 46;
            newArr[4] = 34;
            newArr[5] = 0;
            newArr[6] = 13;
            newArr[7] = 46;

            foreach (int r in newArr)
                Console.WriteLine(r);
            Console.ReadKey();
        }
    }
}

using System;
using System.Linq;

namespace homework.Calculator
{ 
    public class ArrayWords
    {
        //public ArrayWords()
            static void Main(string[] args)
        {
            //2.Поиск максимального элемента в массиве. Для начала задать массив слов.
            //    Размерность массива произвольна, задается в консоли.После чего
            //    в консоли вводятся слова в количестве равном заданной длине массива.
            //    В полученном массиве необходимо найти самое длинное слово. Результат
            //    вывести на консоль

            Console.Write("Введите количество строк, которые хотите ввести: ");
           
            int n = Convert.ToInt32(Console.ReadLine()); // Считываем строку, переводим в число.
            string[] strs = new string[n];//Объявляем массив строк длиной n (которую ввёл пользователь)
            //
            //strs = n.ToCharArray(3, 4);
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите строку №{i + 1}:    ");
                
                strs[i] = Console.ReadLine(); //Заполняем его
            }
            Console.WriteLine("Вы ввели следующие строки:");
            for (int i = 0; i < n; i++)
            {
             
                Console.WriteLine(strs[i].Length);
            var sorted = strs.OrderBy(strs => strs.Length);
            var min = sorted.First();
            var max = sorted.Last();

                Console.WriteLine($"Самое длинное слово:  {min}");

                Console.WriteLine($"Самое короткое слово:  {max}");
                //if (strs[i].Length ==  minLen)
                //{ 
                //Console.WriteLine("самое большое слово " + strs[minLen]);
                //}
                //if(strs[i].Length== maxLen)
                //{
                //    Console.WriteLine("самое маленькое слово " + strs[maxLen]);
                //}
            }
            Console.Write("Нажмите [Enter] для выхода...");
            Console.ReadLine();
           

        }
    }
}

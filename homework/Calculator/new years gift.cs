using System;
namespace homework.Calculator
{
    public class new_years_gift
    {

        private static string green;
        private static string blue;
        private static string red;        

        public static void Main(string[] args)
        {
            Lollipop lollipop = new Lollipop(); // Создание экземпляра класса
            Console.WriteLine(lollipop.uniquParam);
			
			Lollipop lollipop2 = new Lollipop(20, 4000, "Коричневый", "Жвачка внутри"); // Создание экземпляра класса со своими параметрами
            Console.WriteLine(lollipop.uniquParam);
        }
    }
	
    public abstract class Sweet
    {
        public int weight;
        public int cost;
        public string color;
    }

    public class Lollipop : Sweet
    {
		public string uniquParam;
		
        public Lollipop() // Конструктор класса - функция которая вызывается при создании экземпляра класса
        {
            weight = 10;
            cost = 100;
            color = "Синий";
			uniquParam = "Круглый";
        }
		
		public Lollipop(int _weight, int _cost, string _color, string _uniquParam) // Конструктор класса с задаваемыми параметрами
        {
            weight = _weight;
            cost = _cost;
            color = _color;
			uniquParam = _uniquParam;
        }
    }
}
    


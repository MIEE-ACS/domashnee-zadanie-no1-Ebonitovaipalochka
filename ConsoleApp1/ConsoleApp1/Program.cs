using System;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите внешний радиус R1: ");
            double R1 = double.Parse(Console.ReadLine());
            Console.Write("Введите внутренний радиус R2: ");//вводим радиусы окружностей
            double R2 = double.Parse(Console.ReadLine());
            if (R1 > R2)
            {
                double S1 = 3.14 * Math.Pow(R1, 2);
                double S2 = 3.14 * Math.Pow(R2, 2);//считаем площади
                double S3 = S1 - S2;
                Console.WriteLine($"Внешняя площадь равна: {S1:0.00}.");
                Console.WriteLine($"Внутрення площадь равна: {S2:0.00}.");//выводим площади
                Console.WriteLine($"Площадь кольца равна: {S3:0.00}.");
            }
            else
            {
                Console.WriteLine($"Вы неправильно указали радиусы. Укажите радиусы таким образом, чтобы R1 было больше R2.");//ошибка ввода
            }    
        }
    }
}
namespace Task_03_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая выводит на экран таблицу соответствия температуры в градусах Цельсия и
            // Фаренгейта(F = C * 1, 8 + 32).Диапазон изменения температуры в градусах Цельсия и шаг должны вводиться во
           //время работы программы
            Console.WriteLine("Введите начальную температуру в градусах Цельсия:");
            double startCelsius = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите конечную температуру в градусах Цельсия:");
            double endCelsius = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите шаг изменения температуры:");
            double step = double.Parse(Console.ReadLine());

            Console.WriteLine("nТаблица соответствия температуры:");
            Console.WriteLine("ЦельсийtФаренгейт");

            for (double celsius = startCelsius; celsius <= endCelsius; celsius += step)
            {
                double fahrenheit = celsius * 1.8 + 32;
                Console.WriteLine($"{celsius}t{fahrenheit}");
            }
        }
    }
}

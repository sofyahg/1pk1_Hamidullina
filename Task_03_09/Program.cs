namespace Task_03_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 100; // начальная сумма вклада
            int p = 10;  // процент увеличения вклада ежегодно
            int y = 200; // целевая сумма вклада

            int years = 0; // количество лет

            while (x < y)
            {
                x += (x * p) / 100; // увеличиваем вклад на p процентов
                years++;
            }

            Console.WriteLine(years);
        }
    }
}

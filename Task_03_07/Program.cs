namespace Task_03_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Написать программу, которая выводит таблицу скорости (через каждые 0,5с) свободно падающего тела v = g t ,
            //где 2 g = 9,8 м / с2 – ускорение свободного падения.
            double g = 9.8; // ускорение свободного падения в м/с^2
            double timeStep = 0.5; // шаг времени в секундах
            double maxTime = 10.0; // максимальное время для расчета

            Console.WriteLine("Таблица скорости свободно падающего тела:");
            Console.WriteLine("Время (с) t Скорость (м/с)");

            for (double t = 0; t <= maxTime; t += timeStep)
            {
                double v = g * t;
                Console.WriteLine($"{t} tt {v}");
            }
        }
    }
}

﻿namespace Task_04_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] mas = new int[50];    // массив рандомных чисел

            // заполнение массива числами
            for (int i = 0; i < mas.Length; i++)
                mas[i] = rnd.Next(0, 10);

            // проверка на одинаковые пары
            int count = 0;
            for (int i = 1; i < mas.Length; i++)
                if (mas[i - 1] == mas[i])
                    count++;

            Console.WriteLine($"В массиве {count} одинаковых пар элементов!");
        }
    }
}

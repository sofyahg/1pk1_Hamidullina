﻿namespace Task_11_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Передача массива по ссылке (ref): Напишите метод, который принимает массив целых чисел по
ссылке и изменяет его элементы, увеличивая каждый на 1. Проверьте, изменился ли
оригинальный массив вне метода.*/

            Random rnd = new Random();

            Console.WriteLine("Исходный массив:");
            int[] nums = new int[rnd.Next(10, 20)]; // массив
                                                  // заполненение и первичный вывод
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(1, 9);
                Console.Write($"{nums[i]} ");
            }

            IncrementList(ref nums);

            Console.WriteLine("\nРезультирующий массив:");

            foreach (int i in nums)
                Console.Write($"{i} ");
        }

        /// <summary>
        /// увеличивает елементы массива на 1
        /// </summary>
        /// <param name="nums"> массив </param>
        static public void IncrementList(ref int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
                nums[i]++;
        }
    }
}

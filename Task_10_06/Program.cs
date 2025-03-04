namespace Task_10_06
{
    internal class Program
    {
        
        static void Main(string[] args)
        /* Создать Метод ArrayGeneration не возвращающий значения, принимает целое число n,
         * выводит наконсоль сгенерированный массив размерности n*n.*/
        {
            void ArrayGeneration(int n)
            {
                int[,] array = new int[n, n];
                Random rand = new Random();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        array[i, j] = rand.Next(1, 100);      // Генерация случайных чисел от 1 до 99
                        Console.Write(array[i, j] + "t");
                    }
                    Console.WriteLine();
                }
            }

                // Пример вызова метода
            ArrayGeneration(3);
        }
    }
}

namespace Task_05_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Осуществить генерация двумерного [10*5] массива по следующему правилу:
• 1 столбец содержит нули
• 2 столбце содержит числа кратные 2
• 3 столбец содержит числа кратные 3
• 4 столбец содержит числа кратные 4
• 5 столбец содержит числа кратные 5
Осуществить переворот массива (поменять строки и столбцы местами) вывести обновленный массив */

            Random rnd = new Random();
            int[,] massiv = new int[10, 5];        // исходный массив
            int[,] newMassiv = new int[5, 10];     // результирующий массив

            // заполнение исх. массива
            for (int i = 0; i < massiv.GetLength(0); i++)
                for (int j = 0; j < massiv.GetLength(1); j++)
                    massiv[i, j] = j * (j + 1);

            // транспонирование массива и вывод
            for (int i = 0; i < newMassiv.GetLength(0); i++)
            {
                for (int j = 0; j < newMassiv.GetLength(1); j++)
                {
                    newMassiv[i, j] = massiv[j, i];
                    Console.Write($"{newMassiv[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}

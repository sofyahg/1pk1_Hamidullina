namespace Task_05_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Даны два массива, заполненные символами английского алфавита размером 3*3. Проверить, являются ли матрицы равными, если
да, то вывести сообщение о том, что они равны, если нет, то вывести повторно матрицы с цветовой индикацией только тех
элементов, которые равны. (матрицы считаются равными, если их соответствующие элементы равны. */
            Random rnd = new Random();
            char[,] number1 = new char[3, 3];        //1 массив
            char[,] number2 = new char[3, 3];        //2й массив
            char[,] Chars = new char[3, 3];  // массив повторяющихся значений 
            bool matIsEqual = true;                 // переменная равенства массивов

            //рандомное заполнение массивов
            for (int i = 0; i < number1.GetLength(0); i++)
            {
                for (int j = 0; j < number1.GetLength(1); j++)
                {
                    number1[i, j] = (char)rnd.Next('a', 'z' + 1);
                    number2[i, j] = (char)rnd.Next('a', 'z' + 1);

                    /* если символы равны, то запишем их в общий массив,
                     * если нет, переменную равенства массивов приравниваем к false */
                    if (number1[i, j] == number2[i, j])
                    {
                        Chars[i, j] = number1[i, j];
                    }
                    else
                        matIsEqual = false;
                }
            }

            // Вывод 
            if (matIsEqual == true)
                Console.WriteLine("Матрицы равны.");
            else
            {
                Console.WriteLine("Матрица№1 Матрица№2");

                for (int i = 0; i < number1.GetLength(0); i++)
                {
                    // вывод строки 1й матрицы
                    for (int j = 0; j < number1.GetLength(1); j++)
                    {
                        if (Chars[i, j] == 0)
                            Console.BackgroundColor = ConsoleColor.Black;
                        else
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write($"{number1[i, j]} ");
                    }
                    Console.Write("\t  ");

                    //вывод строки 2й матрицы
                    for (int j = 0; j < number2.GetLength(1); j++)
                    {
                        if (Chars[i, j] == 0)
                            Console.BackgroundColor = ConsoleColor.Black;
                        else
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write($"{number2[i, j]} ");
                    }

                    Console.WriteLine();
                }
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
    }

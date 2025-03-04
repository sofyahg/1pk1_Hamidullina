namespace Task_10_07
{
     class Program
    {
        
        
            /* Создайте метод с помощью которого можно сгенерировать
             * и вернуть символьный двумерный массив(состоящий из символов русского алфавита) 
             * и выведите на консоль данный массив с помощью другого метода
             * (который принимает данный массив в качестве параметра)*/
            static void Main()
            {
                char[,] array = GenerateCharArray(3, 3);
                PrintCharArray(array);
            }

            static char[,] GenerateCharArray(int rows, int cols)
            {
                char[,] array = new char[rows, cols];
                Random rand = new Random();
                string rusAlphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        array[i, j] = rusAlphabet[rand.Next(rusAlphabet.Length)];
                    }
                }

                return array;
            }

            static void PrintCharArray(char[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    
}


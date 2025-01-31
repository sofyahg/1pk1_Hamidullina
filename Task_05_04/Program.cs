namespace Task_05_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните является ли данная матрица
диагональной (все элементы вне главной диагонали равны нулю)
Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали. Если нет, то вывеси
сообщение что матрица не является диагональной. */

            Console.WriteLine("Введите размерность матрицы n*n:");
            int a = int.Parse(Console.ReadLine()); 

            Random rnd = new Random();
            int[,] matric = new int[a, a];  // матрица
            bool matricIsDiog = true;       // Булева переменная нужна,чтобы проверить диагональность матрицы

            // рандомное заполнение матрицы 
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    matric[i, j] = rnd.Next(0, 10);

                    // проверка на диагональность
                    if (i != j && matric[i, j] != 0)
                        matricIsDiog = false;
                    else if (i == j && matric[i, j] == 0)
                        matricIsDiog = true;
                }
            }
            // вывод
            if (matricIsDiog == false)
                Console.WriteLine("Матрица не диогональна.");
            else
            {
                for (int i = 0; i < a; i++)
                {
                    for (int j = 0; j < a; j++)
                    {
                        // расскрашиваем диагональные элементы
                        if (i == j)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkMagenta;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        Console.Write($"{matric[i, j]} ");
                        // возвращение в прежний вид
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine();
                }
            }
        }
    }
    }


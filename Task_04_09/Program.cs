namespace Task_04_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] mas = new int[20];        // массив случайных чисел
            int[] uniqMas = new int[20];    // массив уникальных случайных чисел

            Console.WriteLine("Уникальные элементы массива:");

            bool elemIsZero = true;     // елем. является ли 0
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(0, 10);

                /* если элем. 0 выводим его отдельно 
                 * тк массив uniqMas по умолчанию заполнен нулями 
                 * и поиск 0 в нём невозможен */
                if (mas[i] == 0 && elemIsZero == true)
                {
                    elemIsZero = false;
                    Console.Write("0 ");
                }

                // если элем. нет в массиве uniqMas добавить его туда и вывести на консоль
                if (Array.IndexOf(uniqMas, mas[i]) == -1)
                {
                    uniqMas[i] = mas[i];
                    Console.Write($"{mas[i]} ");
                }
            }
            }
    }
}

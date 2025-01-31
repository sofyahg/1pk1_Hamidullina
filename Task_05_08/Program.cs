namespace Task_05_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Даны два массива размером 10*10, заполненные целыми числами в диапазоне от 1 до 9 вкл. Создать новый массив, который будет
произведением двух предыдущих (перемножить элементы первых двух массивов, стоящие на одинаковых позициях и записать их в
результирующий массив)
Вывести результирующий массив */

            Random rnd = new Random();
            int[,] mass1 = new int[10, 10];      //1ый массив
            int[,] mass2 = new int[10, 10];      //2ой массив
            int[,] resultMass = new int[10, 10];    // результирующий массив

            // заполним массивов
            for (int i = 0; i < mass1.GetLength(0); i++)
                for (int j = 0; j < mass1.GetLength(1); j++)
                {
                    mass1[i, j] = rnd.Next(1, 10);
                    mass2[i, j] = rnd.Next(1, 10);

                    resultMass[i, j] = mass1[i, j] * mass2[i, j];
                }

            // вывод
            for (int i = 0; i < resultMass.GetLength(0); i++)
            {
                for (int j = 0; j < resultMass.GetLength(1); j++)
                    Console.Write($"{resultMass[i, j]} ");
                Console.WriteLine();
            }
        
    }
    }
}

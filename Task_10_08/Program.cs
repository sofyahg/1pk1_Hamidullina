namespace Task_10_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Создайте метод, который на вход принимает
             * одномерный массив и число для поиска, 
             * верните индекс искомого элемента в массиве.
             * Если элемента нет – верните индекс = -1*/


            Console.Write("Введите число элементов массива: ");
            int n = Convert.ToInt32(Console.ReadLine());        // число элементов массива

            Console.Write("Введите искомое число в диопазоне от 0 до 9 включительно: ");
            int num = Convert.ToInt32(Console.ReadLine());      // искомое число

            Random rnd = new Random();
            int[] nums = new int[n];    // создаём массив чисел

            Console.WriteLine("\nМассив:");
            // заполняем и выводим
            for (int i = 0; i < n; i++)
            {
                nums[i] = rnd.Next(0, 10);
                Console.Write($"{nums[i]} ");
            }

            Console.WriteLine($"\n\nИндекс искомого значения: {GetValSearchInd(nums, num)}");
        }

        /// <summary>
        /// Возвращает индекс искомого элемента в массиве
        /// </summary>
        /// <param name="nums"> массив чисел </param>
        /// <param name="num"> искомое число </param>
        /// <returns> индекс искомого числа </returns>
        public static int GetValSearchInd(int[] nums, int num)
        {
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] == num)
                    return i;

            return -1;
        }
    }
}
    


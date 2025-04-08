namespace Task_21_01
{
    internal class Program
    {

        /*Написать метод, который удаляет повторяющиеся элементы из списка, сохраняя порядок.
         */

        static void Main(string[] args)
        {
            List<int> numbrs = new List<int> { 1, 5, 1, 3, 3, 7, 12, 75, 43, 63, 43, 9, 4 };
            Console.WriteLine("Список до:");
            foreach (int n in numbrs)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Список после: ");
            DeleteDuplicates.RemoveDuplicates(numbrs);
            foreach (int i in numbrs)
                Console.Write(i + " ");
        }
    }
}

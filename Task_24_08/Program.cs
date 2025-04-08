namespace Task_24_08
{
    internal class Program
    {
       
          /*реализуйте функцию, осуществляющую поиск текста в файле 
        * и его замену на значения, введенные пользователем
        */
        static void Main(string[] args)
        {
            string path = "text.txt";

            Console.Write("Введите текст для поиска: ");
            string search = Console.ReadLine();

            Console.Write("Введите текст для замены: ");
            string replacement = Console.ReadLine();

            //Чтение содержимого
            string fileContent = File.ReadAllText(path);

            //Выполняем замену
            string update = fileContent.Replace(search, replacement);

            //Сохранение изменений
            File.WriteAllText(path, update);
        }
    }
}

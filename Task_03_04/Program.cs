namespace Task_03_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Пользователь вводить в консоли произвольный текст. После каждого ввода консоль очищается.Когда
            //пользователь вводить слово «exit» или пустую строку – ввод останавливается и выводиться количество строк
            //введенных пользователем.
            int lineCount = 0;
            string input;

            do
            {
                Console.Clear();
                Console.WriteLine("Введите текст (для выхода введите 'exit' или оставьте строку пустой):");
                input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input) && input.ToLower() != "exit")
                {
                    lineCount++;
                }

            } while (!string.IsNullOrEmpty(input) && input.ToLower() != "exit");

            Console.WriteLine($"Количество введенных строк: {lineCount}");
        }
    }
}

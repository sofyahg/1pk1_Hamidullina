namespace Task_19_03
{
    internal class Program
    {

        /* Напишите консольное приложение, в котором осуществляется построчный пользовательский
            ввод (ввод каждой строки подтверждается нажатием на enter). количество введенных строк
            произвольно, ввод завершается при вводе пустой строки.
            После окончания ввода произведите объединение всех ранеее введенных строк в одну с
            использованием разделителя «-»
            Например:
            Введите строку 1: "Hello"
            Введите строку 2: "world"
            Введите строку 3: "C#"
            Результат: "Hello-world-C#"*/

        static void Main(string[] args)
        {
            List<string> line = new List<string>();

            Console.WriteLine("Введите строки:");

            while (true)
            {
                string input = Console.ReadLine();

                // Прервём цикл
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                line.Add(input);
            }

            string result = string.Join("-", line);

            Console.WriteLine($"Результат: {result}");
        }
    }
}

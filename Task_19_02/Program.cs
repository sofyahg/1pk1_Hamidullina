namespace Task_19_02
{
    internal class Program
    {

        /* Напишите программу, которая запрашивает у пользователя произвольный текст, содержащий
        предложения (есть знаки препинания). программу после анализа выводит текст, разделенный на
        части:
        a)
        По пробелам (отдельные слова построчно)
        b)
        По предложениям (отдельные предложения построчно)
        (используйте метод Split())*/

        static void Main(string[] args)
        {
            Console.Write("Введите текст: ");
            string text = Console.ReadLine();
            string[] textArray = text.Split();

            foreach (string str1 in textArray)
                Console.WriteLine(str1);

            Console.WriteLine("\n");

            string[] textArray2 = text.Split('.');

            foreach (string str2 in textArray2)
                Console.WriteLine(str2);
        }
    }
}

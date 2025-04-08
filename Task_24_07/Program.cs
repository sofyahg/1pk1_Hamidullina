namespace Task_24_07
{
    internal class Program
    {

         /*Реализуйте функцию, которая ищет заданное слово в текстовом файле 
        * и возвращает все строки, содержащиеэтослово (регистронезависимо).
        */
        static void Main(string[] args)
        {
            string path = "text.txt";
            string word = "опыт";

            List<string> linesWord = FindWord(path, word);

            //Выводим результаты
            foreach (string line in linesWord)
            {
                Console.WriteLine(line);
            }
        }

        static List<string> FindWord(string path, string word)
        {
            List<string> result = new List<string>();


            foreach (string line in File.ReadLines(path))
            {
                result.Add(line);
            }

            return result;
        }
    }
}


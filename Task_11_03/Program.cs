namespace Task_11_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Выходной параметр (out): Напишите метод, который принимает строку и возвращает через
выходной параметр количество гласных и согласных букв в этой строке*/

            Console.WriteLine("Введите строчку >> ");
            string str = Console.ReadLine();

            int counta;       //количество гласных букв
            int countb;  //количество согласных букв

            CountVowAndCons(str, out counta, out countb);

            Console.WriteLine($"Количество гласных букв в строке: {counta}\nСогласных: {countb}");
        }

        /// <summary>
        /// определяет количество гласных и согласных в строке
        /// </summary>
        /// <param name="str"> строка </param>
        /// <param name="counta"> количество гласных </param>
        /// <param name="countb"> количество согласных </param>
        static void CountVowAndCons(string str, out int countVowel, out int countConsonant)
        {
            countVowel = 0;
            countConsonant = 0;

            str = str.ToLower(); //преобразовываем строки в низший регистр

            char[] vowels = { 'a', 'e', 'y', 'u', 'i', 'o' };  //массив гласных букв
            // подсчёт гласных букв в строке
            foreach (char c in str)
                foreach (char vow in vowels)
                    if (vow == c)
                    {
                        countVowel++;
                        break;
                    }

            countConsonant = str.Length - countVowel; // подсчёт согласных букв
        }
    }
}

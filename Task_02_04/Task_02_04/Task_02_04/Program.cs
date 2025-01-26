namespace Task_02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пользователь вводит свою дату рождения построчно (сначала год, потом месяц и в конце дату) произведите
            //расчет является ли пользователь совершеннолетним на текущую дату и выведите соответствующее сообщение об
            //этом
            Console.WriteLine("Введите год своего рождения");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц своего рождения");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите дату своего рождения (число)");
            int number = int.Parse(Console.ReadLine());

            // Создание даты рождения
            DateTime birthDate = new DateTime(year, month, number);

            // Получение текущей даты
            DateTime currentDate = DateTime.Now;

            // Вычисление возраста
            int age = currentDate.Year - birthDate.Year;

            // Проверка дня рождения
            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
            {
                age--;
            }

            // Проверка на совершеннолетие
            if (age >= 18)
            {
                Console.WriteLine("Пользователь является совершеннолетним.");
            }
            else
            {
                Console.WriteLine("Пользователь не является совершеннолетним.");

            }
        }
    }
}

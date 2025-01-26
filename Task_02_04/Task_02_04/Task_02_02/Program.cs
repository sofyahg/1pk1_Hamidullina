namespace Task_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 8;             // Вводим переменные
            double b = 14;
            double c = double.Pi / 4;
            double part1 = Math.Pow(a - 1, 1 / 3);   //Первое действие; кубический корень можно представить в виде степени 1/3       
            double part2 = Math.Pow(b + part1, 1 / 4); // Второе действие; числитель вычислен
            double part3 = Math.Abs(a - b);             // Третье действие; модуль
            double part4 = Math.Pow((Math.Sin(c)), 2);   // Четвертое действие: возводим синус в квадрат 
            double part5 = part4 + Math.Tan(c);      //Пятое действие: сумма синуса и тангенса 
            double part6 = part3 * part5;    // Шестое действие: модуль умножаем на сумму синуса и тангенса; знаменатель вычислен
            double part7 = part2 / part6;     // Седьмое действие: числитель делим на знаменатель
            double result = part7;
            Console.WriteLine(result);
        }
    }
}

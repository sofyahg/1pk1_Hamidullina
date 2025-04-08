namespace Task_20_06
{
    internal class Program
    {


        /*Создайте программу, имитирующую работу светофора, используя перечисление TrafficLightColor:
       • Red
       • Yellow
       • Green
       Реализуйте автоматическое переключение цветов (каждые 3 секунды). 
       При смене цвета выводите его в консоль (можно с задержкой Thread.Sleep). 
       Добавьте возможность ручного переключения (например, по нажатию клавиши).
        */
        static void Main(string[] args)
        {
            TrafficLight trLight = new TrafficLight();

            //Автоматическое переключение в отдельном потоке
            Thread automatThread = new Thread(trLight.Automatic);
            automatThread.Start();

            //Ручное переключение
            trLight.Switch();
        }
    }
}

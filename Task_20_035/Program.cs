namespace Task_20_035
{
    internal class Program
    {
            /*
            Создайте программу для управления статусом заказа в интернет-магазине. Используйте перечисление OrderStatus со значениями:
           New (новый)
           Processing (в обработке)
           Shipped (отправлен)
           Delivered (доставлен)
           Cancelled (отменён)
           Напишите метод, который меняет статус заказа.
           Если заказ уже доставлен или отменён, запретите изменение статуса.
           Выводите сообщение при каждом изменении статуса (например, "Заказ переведён в статус: Отправлен").
           */
            static void Main(string[] args)
            {
                Order ord = new Order();
                Console.WriteLine(ord.Status);

                ord.ChangeStatus();
                ord.ChangeStatus();

                ord.CancelOrder();
                ord.ChangeStatus();
            }
    }
}

namespace Task_20_05
{
    internal class Program
    {
        
       
            /* Напишите программу, имитирующую систему авторизации с использованием перечисления AccessLevel:
       • Guest (только чтение)
       • User (чтение + комментарии)
       • Moderator (удаление контента)
       • Admin (полный доступ)
       Создайте метод, который проверяет, может ли пользователь выполнить действие (например, удалитьпост).
       На основе уровня доступа выводите сообщение (например,
       "Ошибка: Недостаточно прав!").
        */
            static void Main(string[] args)
            {
                User usr = new User(AccesLevel.Guest);
                usr.Reading();
                usr.DeleteContent();

                User usr2 = new User(AccesLevel.User);
                usr2.ReadAndWrite();
                usr2.Full();

                User usr3 = new User(AccesLevel.Moderator);
                usr3.ReadAndWrite();
                usr3.DeleteContent();
                usr3.Full();

                User usr4 = new User(AccesLevel.Admin);
                usr4.Reading();
                usr4.Full();
            }
    }
}

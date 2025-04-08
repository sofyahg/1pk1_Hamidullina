using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20_05
{
    internal class User
    {
        AccesLevel user;

        public User(AccesLevel user)
        {
            this.user = user;
        }

        public void Reading()
        {
            if (user < AccesLevel.User)
                  Console.WriteLine($"{user} имеет доступ только к чтению");
            else Console.WriteLine("Ошибка: Недостаточно прав!");

        }

        public void ReadAndWrite()
        {
            if (user >= AccesLevel.User)
                 Console.WriteLine($"{user} может читать и писать");
            else Console.WriteLine("Ошибка: Недостаточно прав, чтобы писать!");
        }

        public void DeleteContent()
        {
            if (user >= AccesLevel.Moderator)
                 Console.WriteLine($"{user} может удалять контент");
            else Console.WriteLine("Ошибка: Недостаточно прав, чтобы удалять контент");
        }

        public void Full()
        {
            if (user > AccesLevel.Moderator)
                 Console.WriteLine($"{user} может все");
            else Console.WriteLine("Ошибка: недостаточно прав, чтобы иметь полный доступ");
        }
    }
}

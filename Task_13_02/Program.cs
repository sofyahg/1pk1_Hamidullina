﻿namespace Task_13_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            создать класс питомца
            свойства:
            кличка, вид животного, возраст, вес, отметка о состонии здоровья (здоров/нездоров)
               методы:
                вывод информации об объекте
                 изменение значения веса животного
               изменение отметки о состоянии здоровья
             конструторы:
            предусмотрите разные варианты инициализации объектов*/
            Pet pet1 = new Pet("Яша", "Кот", 5, 8, true);
            pet1.GetInfo();
            pet1.ChangeWeight(9);
            pet1.ChangeHealth(false);
            pet1.ChangeWeight(10);
        }
    }
}

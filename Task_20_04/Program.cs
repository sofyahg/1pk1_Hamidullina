﻿using static Task_20_04.Vehicle;

namespace Task_20_04
{
    internal class Program

    {
        /*      Создайте программу для учета транспортных средств. Используйте перечисление VehicleType:
        • Car
        • Bike
        • Bus
        • Truck
        • Motorcycle
            Храните список транспортных средств (можно просто List<VehicleType>). 
        Добавьте метод для подсчёта транспорта определённого типа (например, сколько грузовиков). 
        Реализуйте поиск по типу и вывод информации.*/
        static void Main(string[] args)
        {
            VehicleRegistry registry = new VehicleRegistry();

            //Добавление транспортных средств

            registry.AddVehicle(new Vehicle(VehicleType.Car));
            registry.AddVehicle(new Vehicle(VehicleType.Bike));
            registry.AddVehicle(new Vehicle(VehicleType.Bus));
            registry.AddVehicle(new Vehicle(VehicleType.Truck));
            registry.AddVehicle(new Vehicle(VehicleType.Motorcycle));
            registry.AddVehicle(new Vehicle(VehicleType.Car));


            Console.Write("Введите цифру транспортного средства, количество которого нужно найти: ");
            int Num = Convert.ToInt32(Console.ReadLine());
            VehicleType search = (VehicleType)Num;
            int count = registry.CountVehiclesByType(search);
            Console.WriteLine($"Количество т.с. типа {search}: {count}");
        }
    }
}

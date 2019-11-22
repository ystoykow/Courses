namespace Vehicles
{
    using System;

    public class Program
    {
        public static void Main()
        {
            string[] vehicleInfo = Console.ReadLine().Split();
            double vehicleFuelQuantity = double.Parse(vehicleInfo[1]);
            double vehicleLitersPerKM = double.Parse(vehicleInfo[2]);
            double vehicleTankCapacity = double.Parse(vehicleInfo[3]);
            Vehicle car = new Car(vehicleFuelQuantity, vehicleLitersPerKM, vehicleTankCapacity);

            vehicleInfo = Console.ReadLine().Split();
            vehicleFuelQuantity = double.Parse(vehicleInfo[1]);
            vehicleLitersPerKM = double.Parse(vehicleInfo[2]);
            vehicleTankCapacity = double.Parse(vehicleInfo[3]);
            Vehicle truck = new Truck(vehicleFuelQuantity, vehicleLitersPerKM, vehicleTankCapacity);

            vehicleInfo = Console.ReadLine().Split();
            vehicleFuelQuantity = double.Parse(vehicleInfo[1]);
            vehicleLitersPerKM = double.Parse(vehicleInfo[2]);
            vehicleTankCapacity = double.Parse(vehicleInfo[3]);
            Vehicle bus = new Bus(vehicleFuelQuantity, vehicleLitersPerKM, vehicleTankCapacity);

            int commandsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandsCount; i++)
            {
                string[] commands = Console.ReadLine().Split();
                if (commands[0] == "Drive")
                {
                    double distance = double.Parse(commands[2]);
                    if (commands[1] == "Car")
                    {
                        Console.WriteLine(car.Drive(distance, true));
                    }
                    else if (commands[1] == "Bus")
                    {
                        Console.WriteLine(bus.Drive(distance, true));
                    }
                    else if (commands[1] == "Truck")
                    {
                        Console.WriteLine(truck.Drive(distance, true));
                    }
                }
                else if (commands[0] == "DriveEmpty")
                {
                    double distance = double.Parse(commands[2]);
                    Console.WriteLine(bus.Drive(distance, false));
                }
                else if (commands[0] == "Refuel")
                {
                    try
                    {
                        double liters = double.Parse(commands[2]);
                        if (commands[1] == "Car")
                        {
                            car.Refuel(liters);
                        }
                        else if (commands[1] == "Truck")
                        {
                            truck.Refuel(liters);
                        }
                        else if (commands[1] == "Bus")
                        {
                            bus.Refuel(liters);
                        }
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}

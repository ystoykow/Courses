namespace _10._Crossroads
{
    using System;
    using System.Collections.Generic;

    public class Crossroads
    {
        public static void Main()
        {
            int greenLight = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            int currentGreenLight = greenLight;
            string currentCar = string.Empty;
            bool haveCrash = false;
            Queue<string> cars = new Queue<string>();
            int counter = 0;

            string command = Console.ReadLine();
            while (command != "END")
            {
                while (command != "green")
                {
                    if (command == "END")
                    {
                        break;
                    }

                    cars.Enqueue(command);
                    command = Console.ReadLine();
                }

                if (command == "END")
                {
                    break;
                }

                while (currentGreenLight > 0)
                {
                    if (cars.Count > 0)
                    {
                        currentCar = cars.Dequeue();
                    }
                    else
                    {
                        break;
                    }

                    if (currentGreenLight - currentCar.Length >= 0)
                    {
                        currentGreenLight -= currentCar.Length;
                        counter++;
                    }
                    else if (currentGreenLight + freeWindow - currentCar.Length >= 0)
                    {
                        counter++;
                        break;
                    }
                    else
                    {
                        haveCrash = true;
                        break;
                    }
                }

                if (haveCrash)
                {
                    break;
                }

                currentGreenLight = greenLight;
                command = Console.ReadLine();
            }

            if (haveCrash)
            {
                Console.WriteLine("A crash happened!");
                Console.WriteLine($"{currentCar} was hit at {currentCar[currentGreenLight + freeWindow]}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{counter} total cars passed the crossroads.");
            }
        }
    }
}

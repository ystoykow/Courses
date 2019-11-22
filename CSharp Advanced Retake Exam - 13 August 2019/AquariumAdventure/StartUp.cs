using System;

namespace AquariumAdventure
{
    public class StartUp
    {
        public static void Main()
        {//Sample Code Usage:

            //Initialize Aquarium
            Aquarium aquarium = new Aquarium("Ocean", 2, 15);

            //Initialize Fish
            Fish fish = new Fish("Goldy", "gold", 4);

            //Print Fish
            Console.WriteLine(fish.ToString());

            //Fish: Goldy
            //Color: gold
            //Number of fins: 4

            //Add Fish
            aquarium.Add(fish);

            //Remove Fish
            Fish secondFish = new Fish("Dory", "blue", 2);
            Fish thirdFish = new Fish("Nemo", "orange", 5);

            //Add fish
            aquarium.Add(secondFish);
            aquarium.Add(secondFish);
            aquarium.Add(secondFish);
            aquarium.Add(thirdFish);
            Console.WriteLine(aquarium.FindFish("Goldy"));
            Console.WriteLine(aquarium.FindFish("stoqn"));
            Console.WriteLine(aquarium.Remove("Goldy")); // true
            Console.WriteLine(aquarium.Remove("Goldy")); // true

            //Print Aquarium report
            Console.WriteLine(aquarium.Report());

            //Aquarium Info:
            //Aquarium: Ocean ^ Size: 15
            //Fish: Dory
            //Color: blue
            //Number of fins: 2
            //Fish: Nemo
            //Color: orange
            //Number of fins: 5

        }
    }
}

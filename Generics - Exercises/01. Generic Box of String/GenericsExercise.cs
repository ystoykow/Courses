namespace GenericsExercise
{
    using System;

    public class GenericsExercise
    {
        public static void Main()
        {
            string[] firstArgs = Console.ReadLine().Split();
            string firstName = firstArgs[0] + " " + firstArgs[1];
            string adress = firstArgs[2];
            string town = firstArgs[3];
            Tuple<string,string,string> firstTuple = new Tuple<string, string,string>(firstName,adress,town);
            string[] secondArgs = Console.ReadLine().Split();
            string name = secondArgs[0];
            int liters = int.Parse(secondArgs[1]);
            bool isDrunk = secondArgs[2] == "drunk";
            Tuple<string,int,bool> secondTuple = new Tuple<string, int,bool>(name,liters,isDrunk);
            string[] thirdArgs = Console.ReadLine().Split();
            string accName = thirdArgs[0];
            double doubleNumber = double.Parse(thirdArgs[1]);
            string bankAccount = thirdArgs[2];
            Tuple<string,double,string> thirdTuple = new Tuple<string, double,string>(accName,doubleNumber,bankAccount);
            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}

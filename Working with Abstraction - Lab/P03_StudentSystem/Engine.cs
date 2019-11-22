namespace P03_StudentSystem
{
    public class Engine
    {
        public void Run(DataWriter dataWriter, DataReader dataReader)
        {
            StudentSystem studentSystem = new StudentSystem();
            while (true)
            {
                string[] commands = dataReader.Read().Split(" ");
                string command = commands[0];
                if (command == "Create")
                {
                    string name = commands[1];
                    int age = int.Parse(commands[2]);
                    double grade = double.Parse(commands[3]);
                    studentSystem.Create(name, age, grade);
                }
                else if (command == "Show")
                {
                    string name = commands[1];
                    Student student = studentSystem.Get(name);
                    dataWriter.Write(student);
                }
                else if (command == "Exit")
                {
                    break;
                }
            }
        }
    }
}

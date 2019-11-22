namespace P04_Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Department
    {
        private List<Room> rooms;

        public Department(string name)
        {
            this.Name = name;
            this.rooms = new List<Room>();
            for (int i = 0; i < 20; i++)
            {
                this.rooms.Add(new Room(i + 1));
            }
        }

        public string Name { get; private set; }

        public void AddPatient(Patient patient)
        {
            Room room = this.rooms.FirstOrDefault(r => r.Patients.Count < 3);
            room?.AddPatient(patient);
        }

        public string GetPatient(int id)
        {
            return string.Join(Environment.NewLine,
                this.rooms.
                    Single(r => r.Id == id).
                        Patients.
                        Select(p => p.Name).
                        OrderBy(p => p));
        }

        public string GetAllPatient()
        {
            return string.Join(Environment.NewLine,
                this.rooms.SelectMany(r => r.Patients).Select(p => p.Name));
        }
    }
}

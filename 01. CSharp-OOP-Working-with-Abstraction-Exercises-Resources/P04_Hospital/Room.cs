namespace P04_Hospital
{
    using System.Collections.Generic;

    public class Room
    {
        public Room(int id)
        {
            this.Id = id;
            this.Patients=new List<Patient>(3);
        }

        public int Id { get; private set; }
        public List<Patient> Patients { get; private set; }

        public void AddPatient(Patient patient)
        {
            if (this.Patients.Count <=3)
            {
                this.Patients.Add(patient);
            }
        }
    }
}

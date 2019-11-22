namespace P04_Hospital
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Doctor
    {
        private List<Patient> patients;

        public Doctor(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.patients=new List<Patient>();
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public void AddPatient(Patient patient)
        {
            this.patients.Add(patient);
        }

        public string GetAllPatients()
        {
            return string.Join(Environment.NewLine,this.patients.Select(x => x.Name).OrderBy(p=>p));
        }
    }
}

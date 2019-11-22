namespace P04_Hospital
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Hospital
    {
        public Hospital()
        {
            this.Doctors = new List<Doctor>();
            this.Departments = new List<Department>();
        }

        public List<Doctor> Doctors { get; private set; }

        public List<Department> Departments { get; private set; }

        private void Add(Doctor doctor)
        {
            this.Doctors.Add(doctor);
        }

        private void Add(Department department)
        {
            this.Departments.Add(department);
        }

        public void Add(string[] tokens)
        {
            string departmentName = tokens[0];
            string doctorFirstName = tokens[1];
            string doctorLastName = tokens[2];
            string patientName = tokens[3];

            Doctor doctor = new Doctor(doctorFirstName, doctorLastName);
            if (this.Doctors.All(d => d.FirstName != doctorFirstName && d.LastName != doctorLastName))
            {
                this.Add(doctor);
            }

            Department department = new Department(departmentName);
            if (this.Departments.All(d => d.Name != departmentName))
            {
                this.Add(department);
            }

            Patient patient = new Patient(patientName);

            this.Doctors.First(d=>d.FirstName==doctorFirstName && d.LastName==doctorLastName).AddPatient(patient);
            this.Departments.First(d=>d.Name==departmentName).AddPatient(patient);

        }

        public string GetInfo(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string name = args[0];
            if (args.Length == 1)
            {
                foreach (var depart in this.Departments.Where(d => d.Name == name))
                {
                    sb.AppendLine(depart.GetAllPatient());
                }
            }
            else if (args.Length == 2 && int.TryParse(args[1], out int result))
            {
                sb.AppendLine(this.Departments.FirstOrDefault(d => d.Name == name).GetPatient(int.Parse(args[1])));
            }
            else
            {
                sb.AppendLine(this.Doctors.FirstOrDefault(d => d.FirstName == name).GetAllPatients());
            }

            return sb.ToString().Trim();
        }
    }
}

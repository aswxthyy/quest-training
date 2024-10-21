using System;
using System.Linq;
using System.Collections.Generic;

namespace Patients
{
    class Patient
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string MedCondn { get; set; }
    }
    public enum AppointmentType
    {
        Consultation,
        Surgery,
        FollowUp
    };

    class Appointment
    {
        public int ID { get; set; }
        public int PatientID { get; set; }
        public string DocName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public AppointmentType AppointmentType { get; set; }
       
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var patients = new List<Patient>()
            {
                new Patient{ID = 101, Name = "Aplha", Age = 23, Gender = "F", MedCondn = "Diabetes"},
                new Patient{ID = 102, Name = "Beta", Age = 56, Gender = "F", MedCondn = "Tennis Elbow"},
                new Patient{ID = 103, Name = "Gamma", Age = 76, Gender = "M", MedCondn = "ACL Tear"},
                new Patient{ID = 104, Name = "Delta", Age = 81, Gender = "M", MedCondn = "Diabetes"}

            };

            var appointments = new List<Appointment>()
            {
                new Appointment{ID = 1, PatientID = 101, DocName = "Dr.ABC", AppointmentDate = DateTime.Now.AddDays(7), AppointmentType = AppointmentType.FollowUp},
                new Appointment{ID = 2, PatientID = 102, DocName = "Dr.DEF", AppointmentDate = DateTime.Now.AddDays(14), AppointmentType = AppointmentType.Surgery},
                new Appointment{ID = 3, PatientID = 103, DocName = "Dr.XYZ", AppointmentDate = DateTime.Now.AddDays(7), AppointmentType = AppointmentType.Surgery},
                new Appointment{ID = 4, PatientID = 104, DocName = "Dr.ABC", AppointmentDate = DateTime.Now.AddDays(14), AppointmentType = AppointmentType.Consultation},
                new Appointment{ID = 5, PatientID = 102, DocName = "Dr.DEF", AppointmentDate = DateTime.Now.AddDays(21), AppointmentType = AppointmentType.FollowUp},
            };

            var appointments7 = appointments
                .Where(a => a.AppointmentDate >= DateTime.Now && a.AppointmentDate <= DateTime.Now.AddDays(7))
                .Join(patients,
                    a => a.PatientID,
                    p => p.ID,
                    (a, p) => new
                    {
                        p.Name,
                        p.Age,
                        p.MedCondn
                    });

            System.Console.WriteLine("This Week's Appointments : ");
            foreach (var p in appointments7)
            {
                System.Console.WriteLine($"{p.Name}, Age: {p.Age}, Condition: {p.MedCondn}");
            }

            var grouped7 = appointments
                .Where(a => a.AppointmentDate >= DateTime.Now && a.AppointmentDate <= DateTime.Now.AddDays(7))
                .Join(patients,
                    a => a.PatientID,
                    p => p.ID,
                    (a, p) => new
                    {
                        p.Name,
                        p.Age,
                        p.MedCondn
                    })
                    .GroupBy(p => p.MedCondn);

            System.Console.WriteLine("Grouped Patients : ");
            foreach (var g in grouped7)
            {
                System.Console.WriteLine($"{g.Key} : {g.Count()}");
            }

            
            



        }
    }
}
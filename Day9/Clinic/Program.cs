using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    internal class Program
    {  

        static void AddPatient()
        {
            var patient = new Dictionary<string, string>();

            Console.Write("Enter the Patient's Name : ");
            patient.Add("name", Console.ReadLine());

            Console.Write("Enter the Patient's Age : ");
            patient.Add("age", Console.ReadLine());

            Console.Write("Enter the Patient's Symptoms seperated by a ' , ' : ");
            patient.Add("symptoms", Console.ReadLine());

            patient.Add("id", Guid.NewGuid().ToString());

        }

        static void GetPatient()
        {
            Console.Write("Enter Patient ID : ");
            var id = Console.ReadLine();

            foreach (var patient in patients)
            {
                if (patient["id"] == id)
                {
                    System.Console.WriteLine("Name : " + patient["name"]);
                    System.Console.WriteLine("Age : " + patient["age"]);
                    System.Console.WriteLine("Symptoms : " + patient["symptoms"]);
                    break;
                }
            }
        }
            
        static int GetPatientsBySymptom(List<string> Symptoms)
        {
            Console.Write("Enter Symptom : ");
            var symptom = Console.ReadLine().Trim();

            List<string> patientIDs = new List<string>();

            foreach (var patient in patients)
            {
                if (patient["symptoms"].Contains(symptom))
                {
                    patientIDs.Add(patient["id"]);
                }
            }

            if (patientIDs.Count > 0)
            {
                Console.WriteLine("Patients with symptom '" + symptom + "': " + string.Join(", ", patientIDs));
            }
            else
            {
                Console.WriteLine("No patients found with that symptom.");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("1. Add Patient");
            Console.WriteLine("2. Search Patient by ID");
            Console.WriteLine("3. Search Patients by Symptom");
            Console.WriteLine("4. Exit");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                {
                    AddPatient();
                    break;
                }
                case "2":
                {
                    GetPatient();
                    break;
                }    
                case "3":
                 {
                    GetPatientsBySymptom();
                    break;
                 }   
                case "4":
                {
                    break;
                }
                default:
                {
                    Console.WriteLine("Enter a valid option : ");
                    break;
                }
                        
            }
        }
            


    }
}

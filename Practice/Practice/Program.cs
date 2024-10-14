using System;
using System.Collections.Generic;
using System.Linq;

namespace Practice
{
    internal space Program
    {
        static Dictionary<string, Dictionary<string, string>> patients = new Dictionary<string, Dictionary<string, string>>();
        static void AddPatient()
        {
            Console.WriteLine("Enter Patient ID : ");
            string patientID = Console.ReadLine();

            if(patients.ContainsKey(patientID))
            {
                System.Console.WriteLine("Patient ID already exists.");
            }

            else
            {
                System.Console.WriteLine("Enter Patient ID : ");
                patients.Add("ID", Console.ReadLine());

                System.Console.WriteLine("Enter patient name : ");
                patients.Add("Name", Console.ReadLine());

                System.Console.WriteLine("Enter patient age : ");
                patients.Add("Age", Console.ReadLine());

                System.Console.WriteLine("Enter patient symptoms seperated by a ',' : ");
                patients.Add("Symptoms", Console.ReadLine());
            }
            
        }

        static void GetPatient()
        {
            System.Console.WriteLine("Enter patient ID : ");
            string getID = Console.ReadLine();

            foreach(var patient in patients)
            {
                if(patient["ID"] == getID)
                {
                    System.Console.WriteLine($"Patient ID : {getID}");
                    System.Console.WriteLine($"Name : {patient["Name"]}");
                    System.Console.WriteLine($"Age : {patient["Age"]}");
                    System.Console.WriteLine($"Symptoms : {patient["Symptoms"]}");
                    break;
                }
            }

            if(!patients.ContainsKey(getID))
            {
                System.Console.WriteLine("Patient does not exist");
            }
        }

        static void GetPatientsBySymptom()
        {
            System.Console.WriteLine("Enter a symptom : ");
            string sym = Console.ReadLine();
            
        }



        static void Main(string[] args)
        {

        }

    }
}
using System;
using System.Collections.Generic;

namespace Patient
{
    internal class Program
    {
        static Dictionary<string, Dictionary<string, object>> patients = new Dictionary<string, Dictionary<string, object>>();

        static void AddPatient()
        {
            System.Console.Write("Enter Patient ID : ");
            string ID = Console.ReadLine();

            if (patients.ContainsKey(ID))
            {
                System.Console.WriteLine("Enter a new ID");
            }
            else
            {
                var patientDetails = new Dictionary<string, object>();

                Console.Write("Name : ");
                patientDetails.Add("Name", Console.ReadLine());

                Console.Write("Age : ");
                patientDetails.Add("Age", int.Parse(Console.ReadLine()));

                Console.Write("Diagnosis : ");
                patientDetails.Add("Diagnosis", Console.ReadLine());

                Console.WriteLine("Admission Status : 1. Admitted   2. Not Admitted    3.Discharged");
                string status = Console.ReadLine();

                switch (status)
                {
                    case "1":
                    {
                        patientDetails.Add("AdmissionStatus", "Admitted");
                        break;
                    }
                    case "2":
                    {
                        patientDetails.Add("AdmissionStatus", "Not Admitted");
                        break;
                    }
                    case "3":
                    {
                        patientDetails.Add("AdmissionStatus", "Discharged");
                        break;
                    }
                    default:
                    {
                        System.Console.WriteLine("Enter a valid input");
                        patientDetails.Add("AdmissionStatus", "Not Admitted");
                        break;
                    }
                }

                patients[ID] = patientDetails;
                System.Console.WriteLine("Patient registration successful");
            }
        }

        static void SearchPatient()
        {
            Console.Write("Enter Patient ID to Search : ");
            string searchID = Console.ReadLine();

            if (patients.ContainsKey(searchID))
            {
                var patient = patients[searchID];
                System.Console.WriteLine($"Name : {patient["Name"]}");
                System.Console.WriteLine($"Age : {patient["Age"]}");
                System.Console.WriteLine($"Diagnosis : {patient["Diagnosis"]}");
                System.Console.WriteLine($"Admission Status: {patient["AdmissionStatus"]}");
            }
            else
            {
                System.Console.WriteLine("Patient doesn't exist");
            }
        }

        static void UpdatePatient()
        {
            Console.Write("Enter Patient ID : ");
            string updateID = Console.ReadLine();

            if (patients.ContainsKey(updateID))
            {
                var patient = patients[updateID];

                Console.Write("Updated Diagnosis or (N/A) : ");
                string updatedDiag = Console.ReadLine();

                if (updatedDiag != "N/A")
                {
                    patient["Diagnosis"] = updatedDiag;
                }

                System.Console.WriteLine("Update Admission Status or (N/A) : ");
                System.Console.WriteLine("1. Admitted   2. Not Admitted    3. Discharged");
                string updatedAdmsn = Console.ReadLine();

                switch (updatedAdmsn)
                {
                    case "1":
                    {
                        patient["AdmissionStatus"] = "Admitted";
                        break;
                    }
                    case "2":
                    {
                        patient["AdmissionStatus"] = "Not Admitted";
                        break;
                    }
                    case "3":
                    {
                        patient["AdmissionStatus"] = "Discharged";
                        break;
                    }
                    case "N/A":
                    {
                        return; 
                    }
                    default:
                    {
                        System.Console.WriteLine("Enter a valid input");
                        break;
                    }
                }

                System.Console.WriteLine("Patient updation successful");
            }
            else
            {
                System.Console.WriteLine("Patient doesn't exist");
            }
        }

        static void AdmittedPatients()
        {
            System.Console.WriteLine("Admitted Patients :");
            foreach (var patient in patients)
            {
                if (patient.Value["AdmissionStatus"].ToString() == "Admitted")
                {
                    System.Console.WriteLine("Name : " + patient.Value["Name"]);
                    System.Console.WriteLine("Age : " + patient.Value["Age"]);
                    System.Console.WriteLine("Diagnosis : " + patient.Value["Diagnosis"]);
                }
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine("1. Add Patient");
                System.Console.WriteLine("2. Search Patient");
                System.Console.WriteLine("3. Update Patient");
                System.Console.WriteLine("4. Admitted Patients");
                System.Console.WriteLine("5. Exit");
                var opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                    {
                        AddPatient();
                        break;
                    }
                    case "2":
                    {
                        SearchPatient();
                        break;
                    }
                    case "3":
                    {
                        UpdatePatient();
                        break;
                    }   
                    case "4":
                    {
                        AdmittedPatients();
                        break;
                    }
                    case "5":
                    {
                        return;
                    }
                    default:
                    {
                        System.Console.WriteLine("Enter a valid option");
                        break;
                    }
                }
            }
        }
    }
}


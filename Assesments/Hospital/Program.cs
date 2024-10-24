using System;
using System.Linq;
using System.Collections.Generic;

namespace Hospital
{
    internal class Program
    {
        var patient = new PatientRepository();
        var doctor  = new DoctorRepository();
        static void Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine("Welcome! Choose an option to manage");
                System.Console.WriteLine("1. Patients");
                System.Console.WriteLine("2. Doctors");
                string opt = Console.ReadLine();

                switch(opt)
                {
                    case "1":
                        PatientManager(patient);
                        break;
                    case "2":
                        DoctorManager(doctor);
                        break;
                    default:
                        System.Console.WriteLine("Invalid Option");
                        break;
                }
            }

        }

        static void PatientManager(PatientRepository patient)
        {
            while(true)
            {
                System.Console.WriteLine("1. Add");
                System.Console.WriteLine("2. Get");
                System.Console.WriteLine("3. Update");
                System.Console.WriteLine("4. Delete");
                System.Console.WriteLine("5. Exit");
                string opt = Console.ReadLine();

                switch(opt)
                {
                    case "1" :
                    {
                        var p = new Patient();

                        System.Console.Write("Name : ");
                        var name = Console.ReadLine();
                        if(!name.IsNullOrWhiteSpace())
                        {
                            p.Name = name;
                        }
                        else
                        {
                            System.Console.WriteLine("Enter a valid name");
                        }

                        System.Console.Write("Age : ");
                        var age = int.Parse(Console.ReadLine());
                        if(age > 0 && age < 150)
                        {
                            p.Age = age;
                        }
                        else
                        {
                            System.Console.WriteLine("Enter a valid age.");
                        }

                        System.Console.Write("Gender (Male/Female/Other) : ");
                        p.Gender = Console.ReadLine();

                        System.Console.Write("Medical Condition : ");
                        p.MedicalCondition = Console.ReadLine();

                        try
                        {
                            patient.Add(p);
                            System.Console.WriteLine("Patient Registered");
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine($"Failed to Register Patient : {e.Message}");
                        }
                        break;
                    }

                    case "2" :
                    {
                        var patients = patient.Select();
                        foreach (var patient in patients)
                        {
                            System.Console.WriteLine($"ID : {patient.Id}    Name : {patient.Name}    Age : {patient.Age}   Gender: {patient.Gender}");
                            System.Console.WriteLine($"Medical Condition : {patient.MedicalCondition}");
                        }
                    }

                    case "3" :
                    {
                        System.Console.Write("Patient ID to update: ");
                        var id = int.Parse(Console.ReadLine());

                        var p = patient.Select(id);

                        System.Console.Write("Name : ");
                        var name = Console.ReadLine();
                        if(!name.IsNullOrWhiteSpace())
                        {
                            p.Name = name;
                        }
                        else
                        {
                            System.Console.WriteLine("Enter a valid name");
                        }

                        System.Console.Write("Age : ");
                        var age = int.Parse(Console.ReadLine());
                        if(age > 0 && age < 150)
                        {
                            p.Age = age;
                        }
                        else
                        {
                            System.Console.WriteLine("Enter a valid age.");
                        }

                        System.Console.Write("Gender (Male/Female/Other) : ");
                        p.Gender = Console.ReadLine();

                        System.Console.Write("Medical Condition : ");
                        p.MedicalCondition = Console.ReadLine();

                        try
                        {
                            patient.Update(p);
                            System.Console.WriteLine("Patient Updated");
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine($"Failed to Update Patient : {e.Message}");
                        }
                        break;
                       
                    }
                    case "4":
                    {
                        System.Console.Write("Patient ID to delete: ");
                        int id = int.Parse(Console.ReadLine());

                        try
                        {
                            patient.Delete(id);
                            System.Console.WriteLine("Patient Deleted");
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine($"Failed to Delete Patient : {e.Message}");
                        }
                        break;
                    }

                    case "5" :
                        return;

                    default :
                        System.Console.WriteLine("Invalid Option");
                        break;

                }
            }
        }

        static void DoctorManager(DoctorRepository doctor)
        {
            while (true)
            {
                System.Console.WriteLine("1. Add");
                System.Console.WriteLine("2. Get");
                System.Console.WriteLine("3. Update");
                System.Console.WriteLine("4. Delete");
                System.Console.WriteLine("5. Exit");
                string opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                    {
                        var d = new Doctor();

                        System.Console.Write("Name : ");
                        var name = Console.ReadLine();
                        if(!name.IsNullOrWhiteSpace())
                        {
                            d.Name = name;
                        }
                        else
                        {
                            System.Console.WriteLine("Enter a valid name");
                        }

                        System.Console.Write("Specialization: ");
                        d.Specialisation = Console.ReadLine();

                        System.Console.Write("PatientID : ");
                        d.PatientID = Console.ReadLine();

                        try
                        {
                            doctor.Add(d);
                            System.Console.WriteLine("Doctor Registered");
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine($"Failed to Register Doctor : {e.Message}");
                        }
                        break;
                    }

                    case "2":
                    {
                        var doctors = doctor.Select();
                        foreach (var doc in doctors)
                        {
                            System.Console.WriteLine($"ID: {doc.Id}    Name: {doc.Name}    Specialization: {doc.Specialisation}    Patient ID: {doc.PatientID}");
                        }
                        break;
                    }

                    case "3":
                    {
                        System.Console.Write("Doctor ID to update: ");
                        var id = int.Parse(Console.ReadLine());

                        var d = doctor.Select(id);

                        System.Console.Write("Name : ");
                        var name = Console.ReadLine();
                        if(!name.IsNullOrWhiteSpace())
                        {
                            d.Name = name;
                        }
                        else
                        {
                            System.Console.WriteLine("Enter a valid name");
                        }

                        System.Console.Write("Specialization: ");
                        d.Specialisation = Console.ReadLine();

                        System.Console.Write("PatientID: ");
                        d.PatientID = Console.ReadLine();

                        try
                        {
                            doctor.Update(d);
                            System.Console.WriteLine("Doctor Updated");
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine($"Failed to Update Doctor : {e.Message}");
                        }
                        break;
                    }

                    case "4":
                    {
                        System.Console.Write("Doctor ID to delete: ");
                        int id = int.Parse(Console.ReadLine());

                        try
                        {
                            doctor.Delete(d);
                            System.Console.WriteLine("Doctor Registered");
                        }
                        catch (Exception e)
                        {
                            System.Console.WriteLine($"Failed to Delete Doctor : {e.Message}");
                        }
                        break; 
                    }

                    case "5":
                        return;

                    default:
                        System.Console.WriteLine("Invalid Option");
                        break;

                }
            }
        }
    }
}
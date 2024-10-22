using System;
using System.Collections.Generic;

namespace Details
{
    internal class Program
    {
        public static Dictionary<string, object> personalDetails = new Dictionary<string, object>();

        static void AddPerson()
        {

            Console.Write("Name : ");
            personalDetails.Add("Name", Console.ReadLine());

            Console.Write("Phone Number : ");
            personalDetails.Add("PhNo" : Console.ReadLine());

            Console.Write("Email : ");
            personalDetails.Add("Email", Console.ReadLine());

        
            System.Console.WriteLine("Personal Details added successful");
                
        }
    }

        static void SearchPatient()
        {
            Console.Write("Enter Patient ID to Search : ");
            string searchID = Console.ReadLine();

            if (patients.ContainsKey(searchID))
            {
                var patient = personals[searchID];
                System.Console.WriteLine($"Name : {personal["Name"]}");
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



/*
using System;
using System.Collections.Generic;
using System.Linq;

namespace Details
{
    public class PersonalDetails
    {
        public string Name { get; set; }
        public string PhNo { get; set; }
        public string Email { get; set; }

        public PersonalDetails(string name, string phno, string email)
        {
            Name = name;
            PhNo = phno;
            Email = email;
        }
    }

    internal class Program
    {
        static void InsertDetails(List<PersonalDetails> people)
        {

            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();

                foreach (var person in people)
                {
                    var insertQuery = @"INSERT INTO PEOPLE (name, phno, email) VALUES (@name, @phno, @email)";
                    using (var command = new SqlCommand(insertQuery, conn))
                    {
                        command.Parameters.AddWithValue("@name", person.Name);
                        command.Parameters.AddWithValue("@phno", person.PhNo);
                        command.Parameters.AddWithValue("@email", person.Email);

                        command.ExecuteNonQuery();
                    }
                }

                conn.Close();
                Console.WriteLine("Personal Details inserted successfully.");
            }
        }
        static void Main(string[] args)
        {
            const string connStr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Aswathy\Documents\QuestDB.mdf; Integrated Security = True;";

            var createTableQuery = @"CREATE TABLE PEOPLE
                                        (name varchar(50),
                                        phno varchar(10),
                                        email varchar(50)
                                        )";
            var conn = new SqlConnection(connStr);
            conn.Open();

            var command = new SqlCommand(createTableQuery, conn);
            command.ExecuteNonQuery();

            conn.Close();

            var person = new List<PersonalDetails>()
            {
                new PersonalDetails("Alpha", "6567869873", "alpha@mail.com"),
                new PersonalDetails("Beta", "8987869873", "beta@mail.com"),
                new PersonalDetails("Gamma", "9797869873", "alpha@mail.com"),
                new PersonalDetails("Delta", "2327869873", "delta@mail.com"),
                new PersonalDetails("Epsilon", "1217869873", "epsilon@mail.com")
            };

            InsertDetails(person);
        }

    }
}
*/




/*
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SqlInsertFromList
{
    internal class Program
    {
        const string connStr = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Rahul vv\Documents\QuestDB.mdf; Integrated Security = True;";

        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book("Book 1", "Author A", 500),
                new Book("Book 2", "Author B", 600),
                new Book("Book 3", "Author C", 700),
                new Book("Book 4", "Author D", 800),
                new Book("Book 5", "Author E", 900)
            };

            InsertBooksIntoDatabase(books);
        }

        static void InsertBooksIntoDatabase(List<Book> books)
        {
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();

                foreach (var book in books)
                {
                    var insertQuery = @"INSERT INTO BOOKS (name, author, price) VALUES (@name, @author, @price)";
                    using (var command = new SqlCommand(insertQuery, conn))
                    {
                        command.Parameters.AddWithValue("@name", book.Name);
                        command.Parameters.AddWithValue("@author", book.Author);
                        command.Parameters.AddWithValue("@price", book.Price);

                        command.ExecuteNonQuery();
                    }
                }

                conn.Close();
                Console.WriteLine("Books inserted successfully.");
            }
        }
    }

    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }

        public Book(string name, string author, int price)
        {
            Name = name;
            Author = author;
            Price = price;
        }
    }
}
*/
using System;
using System.Collections.Generic;
using OOPS;

namespace OOPS
{
    class Student 
    {
        public string Name;

        public void DisplayName()
        {
            System.Console.WriteLine(Name.ToUpper());
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();//object 
            s1.Name = "John";
            s1.DisplayName();

            Student s2 = new Student();
            s2.Name = "Doe";
            s2.DisplayName();
        }

    }

    class Employee
    {
        public string FirstName;
        public string LastName;
        public int Salary;

        public void AnnualSalary()
        {
            System.Console.WriteLine($"Annual Salary of {FirstName} {LastName} : {Salary * 12}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.FirstName = "John";
            e1.LastName = "Doe";
            e1.Salary = 55000;
            e1.AnnualSalary();

            Employee e2 = new Employee();
            e2.FirstName = "Jane";
            e2.LastName = "Darwin";
            e2.Salary = 66000;
            e2.AnnualSalary();
        }
    }
    class Student
    {
        public string Name;
        public int Mark1;
        public int Mark2;
        public int Mark3;

        public void TotalMarks()
        {
            System.Console.WriteLine($"Total Marks of {Name} : {Mark1 + Mark2 + Mark3}");
        }
        public void AvgMarks()
        {
            System.Console.WriteLine($"Average Marks of {Name} : {(Mark1 + Mark2 + Mark3) / 3}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Name = "Alpha";
            s1.Mark1 = 99;
            s1.Mark2 = 34;
            s1.Mark3 = 98;

            Student s2 = new Student();
            s2.Name = "Beta";
            s2.Mark1 = 90;
            s2.Mark2 = 76;
            s2.Mark3 = 45;

            Student s3 = new Student();
            s3.Name = "Gamma";
            s3.Mark1 = 75;
            s3.Mark2 = 85;
            s3.Mark3 = 81;

            s1.TotalMarks();
            s1.AvgMarks();
            System.Console.WriteLine();

            s2.TotalMarks();
            s2.AvgMarks();
            System.Console.WriteLine();

            s3.TotalMarks();
            s3.AvgMarks();
            System.Console.WriteLine();




        }
    }

    class Smartphone
    {
        public string Model;
        public string Manufacturer;
        public List<int> Storage;

        public void DisplayDetails()
        {
            System.Console.WriteLine($"Model : {Model}");
            System.Console.WriteLine($"Manufacturer : {Manufacturer}");
            System.Console.WriteLine($"Storage : {string.Join(", ", Storage)}");
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Smartphone s1 = new Smartphone
            {
                Model = "S23",
                Manufacturer = "Samsung",
                Storage = new List<int>{16,256}
            };

            Smartphone s2 = new Smartphone
            {
                Model = "Pixel 6",
                Manufacturer = "Google",
                Storage = new List<int>{8,128}
            };

            Smartphone s3 = new Smartphone
            {
                Model = "iPhone 13",
                Manufacturer = "Apple",
                Storage = new List<int>{4,64}
            };

            s1.DisplayDetails();
            s2.DisplayDetails();
            s3.DisplayDetails();

           
        }
    }

    class Calculator
    {
        public int a;
        public int b;

        public void Add() => System.Console.WriteLine($"Sum : {a + b}");
        public void Sub() => System.Console.WriteLine($"Difference : {a - b}");
        public void Mul() => System.Console.WriteLine($"Product : {a * b}");
        public void Div() => System.Console.WriteLine($"Quotient : {a / b}");

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator num = new Calculator
            {
                a = 10,
                b = 20
            };

            num.Add();
            num.Sub();
            num.Mul();
            num.Div();

           
        }
    }

    class Student
    {
        public string Name;
        public int Mark1;
        public int Mark2;
        public int Mark3; 

    }
    internal class Program
    {
        static void Main(string[] args)
        {
           var s1 = new Student{
            Name = "Student 1",
            Mark1 = 13,
            Mark2 = 15,
            Mark3 = 18
           };

           var s2 = new Student{
            Name = "Student 2",
            Mark1 = 20,
            Mark2 = 19,
            Mark3 = 12
           };

            var s3 = new Student{
            Name = "Student 3",
            Mark1 = 10,
            Mark2 = 14,
            Mark3 = 17
           };

            var s4 = new Student{
            Name = "Student 4",
            Mark1 = 9,
            Mark2 = 3,
            Mark3 = 19
           };

            var s5 = new Student{
            Name = "Student 5",
            Mark1 = 6,
            Mark2 = 15,
            Mark3 = 19
           };

           Student?[] students = new Student?[5];
           students[0] = s1;
           students[1] = s2;
           students[2] = s3;
           students[3] = null;
           students[4] = null;
        
           foreach(var student in students)
           {
            if(student != null)
            {
                int total = student.Mark1 + student.Mark2 + student.Mark3;
                System.Console.WriteLine($"Name: {student.Name}");
                System.Console.WriteLine($"Total Marks: {total}");
            }
            else 
                System.Console.WriteLine("NULL");
            
           }



           
        }
    }

     public class CreditCard
    {
        public int CardNumber;
        public string Expiry;
        public int Cvc;
        
    }
    internal class Program
    {
    static void Main(string[] args)
    {
            CreditCard cc = new CreditCard();

            Console.WriteLine("Enter card number");
            cc.CardNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter expiry");
            cc.Expiry = Console.ReadLine();

            Console.WriteLine("Enter cvc");
            cc.Cvc = int.Parse(Console.ReadLine());

    }


    
}
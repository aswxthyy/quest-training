using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var d = new Dictionary<string,string>();
            // d.Add("First Name", "John");
            // d.Add("Last Name", "Doe");

            // System.Console.WriteLine(d["First Name"]);

            // d["First Name"] = "Jane";
            // System.Console.WriteLine(d["FirstName"]);

            // d.Remove("Last Name");

            // if(d.ContainsKey("Age"))
            // {
            //     System.Console.WriteLine("Age present");
            // }

            // else 
            // {
            //     System.Console.WriteLine("Age not a key");
            // }
                
            // foreach(var item in d)
            // {
            //     System.Console.WriteLine($"{item.Key} : {item.Value}");
            // }

            //-----------------------

            // var d = new Dictionary<string,string>();
            
            // for(int i = 0; i < 2; i++)
            // {
            //     Console.Write("Enter the Student ID : ");
            //     int sid = int.Parse(Console.ReadLine());

            //     var marks = new List<int>();
            //     for(int j = 1; j <= 3; j++)
            //     {
            //         Console.Write("Enter the marks ");
            //         int mark = int.Parse(Console.ReadLine());

            //         marks.Add(mark);
            //     }
            //     input.Add(marks);
            // }
            // Console.ReadLine();

            var d = new Dictionary<string, List<int>>();

            System.Console.WriteLine("Enter the number of students : ");
            int s = int.Parse(Console.ReadLine());

            for (int i = 0; i < s; i++)
            {
                Console.Write("Enter the Student ID: ");
                var sid = Console.ReadLine();
                
                if (d.ContainsKey(sid))
                {
                    Console.WriteLine("Student ID already exists.");
                    Console.WriteLine("1 : Overwrite   2 : Skip Duplicate");
                    var choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        Console.WriteLine("Overwriting existing data");
                    }
                    else
                    {
                        Console.WriteLine("Skipping duplicate");
                        continue;
                    }
                }

                var marks = new List<int>();
                for (int j = 1; j <= 3; j++)
                {
                    Console.Write($"Enter marks for subject {j}: ");
                    int mark = int.Parse(Console.ReadLine());

                    marks.Add(mark); 
                }
                d[sid] = marks;
            }
            System.Console.WriteLine();

            foreach (var data in d)
            {
                Console.Write($"Student ID : {data.Key}    Marks: ");
                foreach (var mark in data.Value)
                {
                    Console.Write(mark + " ");
                }
                 
            }



        }
    }
}


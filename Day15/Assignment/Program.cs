using System;
using System.Linq;
using System.Collections.Generic;

namespace Assignment
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            
            //var list = new List<int>{1,2,3,1,2,4,5,6,7,8,9,10,-5,-5,-4,23,45,60,69,89,97};
            //var list = new List<string>{"Apple", "Banana", "Apricot", "Peach", "Berries"};

            // 1
            // var even = list.Where(x => x % 2 == 0);
            // foreach(var i in even)
            // {
            //     System.Console.WriteLine(i);
            // }

            // 2
            // var startsA = list.Where(x => x.StartsWith("A"));
            // foreach(var a in startsA)
            // {
            //     System.Console.WriteLine(a);
            // }

            // 3
            // var desc = list.OrderByDescending(x => x);
            // foreach(var i in desc)
            // {
            //     System.Console.WriteLine(i);
            // }

            // 4
            // var square = list.Select(x => x * x);
            // foreach(var i in square)
            // {
            //     System.Console.WriteLine(i);
            // }

            // 5
            // var evenSquare = list.Where(x => x % 2 == 0).Select(x => x * x);
            // foreach(var i in evenSquare)
            // {
            //     System.Console.WriteLine(i);
            // }

            // 6
            // var startsB = list.Where(x => x.StartsWith("B")).FirstOrDefault();
            // System.Console.WriteLine(startsB);
            
            // 7
            // var names = new List<string>(){"Alpha", "Beta", "Gamma", "Delta"};
            // var marks = new List<int>(){66,75,88,90};

            // //var zip = names.Zip(marks);

            // var zip = names
            //             .Zip(marks, (name, mark) => {return new {name, mark};})
            //             .Where(s => s.mark > 80)
            //             .Select(s => s.name);

            // foreach(var i in zip)
            // {
            //     System.Console.WriteLine(i);
            // }


            // 8
            // var groups = list.GroupBy(g => g.Length);
            // foreach(var group in groups)
            // {
            //     System.Console.WriteLine($"Word Length {group.Key} : {group.Count()}");
            //     foreach(var fruit in group)
            //     {
            //         System.Console.WriteLine($"\t{fruit}");
            //     }
            // }

            // 9
            // var max = list.Max();
            // System.Console.WriteLine(max);

            // 10
            // var min = list.Min();
            // System.Console.WriteLine(min);

            // 11
            // var g50 = list.Where(x => x > 50);
            // foreach(var g in g50)
            // {
            //     System.Console.WriteLine(g);
            // }

            // 12
            // var pos = list.All(x => x > 0);
            // System.Console.WriteLine(pos);

            // 13
            // var sum = list.Sum();
            // System.Console.WriteLine(sum);

            // 14
            // var floatNums = new List<float>{1.2F, 3.4F, 5.66F, 3.14F, 10.01F, 11.11F};

            // var avg = floatNums.Average();
            // System.Console.WriteLine(avg);

            // 15
            // var u = list.Distinct();
            // foreach(var i in u)
            // {
            //     System.Console.WriteLine(i);
            // }

            // // 16
            // var g10 = list.Count(x => x > 10);
            // System.Console.WriteLine(g10);

            // 17
            // var employee = new List<Employee>()
            // {
            //     new Employee{Name = "Alpha", DeptID = 1},
            //     new Employee{Name = "Beta", DeptID = 2},
            //     new Employee{Name = "Gamma", DeptID = 1},
            //     new Employee{Name = "Delta", DeptID = 3},
            //     new Employee{Name = "Epsilon", DeptID = 2}
            // };

            // var department = new List<Departments>()
            // {
            //     new Departments{ID = 1, Department = "Computer Science"},
            //     new Departments{ID = 2, Department = "Mechanical"},
            //     new Departments{ID = 3, Department = "Architecture"}
            // };

            // var empWithDepts = employee
            //                     .Join(
            //                         department,
            //                         e => e.DeptID,
            //                         d => d.ID,
            //                         (e, d) => new
            //                         {
            //                             EmployeeName = e.Name,
            //                             DepartmentName = d.Department
            //                         }
            //                     );
            // foreach(var i in empWithDepts)
            // {
            //     System.Console.WriteLine(i.EmployeeName + " : " + i.DepartmentName);
            // }


            // 18
            // var products = new List<Products>
            // {
            //     new Products{Product = "Bourbon", Price = 20},
            //     new Products{Product = "Hide and Seek", Price = 30},
            //     new Products{Product = "Nice", Price = 110},
            //     new Products{Product = "Dark Fantasy", Price = 160},
            //     new Products{Product = "Milano", Price = 165}
            // };

            // var g100 = products.Where(x => x.Price > 100).OrderBy(x => x.Price);
            // foreach(var g in g100)
            // {
            //     System.Console.WriteLine($"Product : {g.Product}    Price : {g.Price}");
            // }

            // 19
            // var skiptake = list.Skip(5).Take(3);
            // foreach(var i in skiptake)
            // {
            //     System.Console.WriteLine(i);
            // }

            // 20
            // var names = new List<string>{"Alpha", "Beta", "Gamma", "Delta"};
            // var marks = new List<int>{66,75,88,90};

            // var zip = names.Zip(marks);
            // foreach(var i in zip)
            // {
            //     System.Console.WriteLine(i);
            // }



        }
    }

    // class Employee
    // {
    //     public int DeptID { get; set; }
    //     public string Name { get; set; }

    //     public override string ToString()
    //     {
    //         return $"Name : {Name}   DeptID : {DeptID}";
    //     }
    // }

    // class Departments
    // {
    //     public int ID { get; set; }
    //     public string Department { get; set; }

    //     public override string ToString()
    //     {
    //         return $"Department : {Department}   ID : {ID}";
    //     }
    // }

    // class Products
    // {
    //     public string Product { get; set; }
    //     public int Price { get; set; }
    // }
}
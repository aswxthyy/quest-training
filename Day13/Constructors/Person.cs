namespace LearnCSharp
{
    class Employee
    {
        public string Name { get; set; }
        public static string CompanyName { get; set; }
        override public string ToString() => $"Name: {Name}, Company: {CompanyName}";
    }

    internal class Program
    {
        static void Main()
        {
            Employee. CompanyName = "Old Name";
            var e1 = new Employee { Name = "E1"};
            var e2 = new Employee {Name = "E2"};
            Console. WriteLine(e1);
            Console. WriteLine(e2);
            Employee. CompanyName = "New Name";
            Console WriteLine(e1);
            Console. WriteLine(e2);

        }
    }
    
}

/*
STATIC:
- Created only once in the memory.

- Accessed in the name of the class. (AppSettings. Version)

- Cannot be accessed through objects. (obj. Version) // Not possible

- Value can be modified.
CONST:


- Created only once in the memory.

- Accessed in the name of the class. (AppSettings. Version)

- Cannot be accessed through objects. (obj.Version) // Not possible

- Value cannot be modified.

STATIC READONLY:

- Created only once in the memory.

- Accessed in the name of the class. (AppSettings. Version)

- Cannot be accessed through objects.
(obj. Version) // Not possible
- Value can be modified only from a static constructor.
READONLY:

- Created for each objects.

- Accessed in the name of the object. (obj Version)

- Cannot be accessed through Class Name. (AppSettings.Version) // Not possible
- Value can be modified only from a constructor.
*/

// namespace LearnCSharp
// {
//     static class AppSettings
//     {
//         public static string Version → "1.0.0";
//         //public static string Version i get; 3 = "1.0.0";
//         public static string ProjectUrl => "https://github.com/";
//         public static string AdminDashboardUrl => "https:/www.myapp.com/admin";
//         public static string DefaultSearchEngine { get; set; } = "Google";
//     }

//        internal class Program
//     {
//         static void Main()
//         {
//             AppSettings. DefaultSearchEngine = "bing";
//             AppSettings Version = "2.0.0";
//             Console. WriteLine(AppSettings.DefaultSearchEngine);
//         }

//     }

// }

namespace LearnCSharp
{
    class Employee
    {
        public string Name { get; set; } 
        public static string CompanyName { get; set; }
    }

    static Employee //static Constructor
    {
        CompanyName = "Microsoft";
    }

    public Employee (string name) => Name = name;
    public override string ToString() => Name + " " + CompanyName

    internal class Employee
    {
        static void Main()
        {
            Console.WriteLine("Company Name: " + Employee. CompanyName);
            var e1 = new Employee ("Joe");
            Console WriteLine(e1);
        }
    }

}


using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var data = new int[]{1,2,3,4,5,6,7,8,9,10,-5,-4,23,45};

            // var a = data.Skip(3).Take(5).Where(x => x % 2 == 0).Sum();
           

            // var first = data.First();
            // var firstdefault = data.FirstOrDefault();
            // var last = data.Last();
            // var lastdefault = data.LastOrDefault();

            // var order = data.OrderBy(x => x);
            // var orderdesc = data.OrderByDescending(x => x);

            // var count = data.Count(x => x > 5);
            // var max = data.Max(x => x > 5);
            // var min = data.Min(x => x > 5);

            // var check = data.Contains(5);
            // var dis = data.Distinct();

            // var take = data.Take(5);
            // var takew = data.TakeWhile(i => i < 5);
            // var skip = data.Skip(3);
            // var skipw = data.SkipWhile(x => x > 5);
            // System.Console.WriteLine(order);

            var data = new List<Person>()
            {
                new Person{Name = "ABC", Country = "US", Age = 76},
                new Person{Name = "DEF", Country = "US", Age = 56},
                new Person{Name = "LMN", Country = "CA", Age = 34},
                new Person{Name = "XYZ", Country = "IN", Age = 21},
            };

            // var res = data.Where(p => p.Country == "US");
            // foreach(var person in res)
            // {
            //     System.Console.WriteLine(person.Name);
            // }

            // var minAge = data.Where(p => p.Country == "US").Min(p => p.Age);
            // var minnnAge = data.Where(p => p.Country == "US" && p.Age == minAge).FirstOrDefault();
            // System.Console.WriteLine(minnnAge.ToString());

            // var ageSort = data.OrderByDescending(p => p.Age).ToList();
            // var countries = data.Select(p => p.Country).Distinct().ToList();

            // foreach(var p in ageSort)
            // {
            //     System.Console.WriteLine(p.Age);
            // }

            // foreach (var country in countries)
            // {
            //     System.Console.WriteLine(country);
            // }

            var groups = data.GroupBy(p => p.Country);

            foreach(var group in groups)
            {
                System.Console.WriteLine($"{group.Key} : {group.Count()}");
                foreach(var person in group)
                {
                    System.Console.WriteLine($"\t{person}");
                }
            }





        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }


        public override string ToString()
        {
            return $"Name: {Name}   Country: {Country}  Age: {Age}";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    static class Program
    {
        public static void Main(string[] args)
        {
            //Local
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            //Global
            DateTime dtu = DateTime.UtcNow;
            Console.WriteLine(dtu);

            System.Console.WriteLine($"Day : {dt.Day}");
            System.Console.WriteLine($"Month : {dt.Month}");
            System.Console.WriteLine($"Year : {dt.Year}");

            System.Console.WriteLine($"Hour : {dt.Hour}");
            System.Console.WriteLine($"Minute : {dt.Minute}");
            System.Console.WriteLine($"Second : {dt.Second}");
            System.Console.WriteLine($"Millisecond : {dt.Millisecond}");
            
            var tenFromToday = dt.AddDays(10);
            System.Console.WriteLine(tenFromToday);

            var twentyFromToday = dt.AddHours(20).AddDays(20);
            System.Console.WriteLine(twentyFromToday);

            System.Console.WriteLine($"Standard {dt}");
            System.Console.WriteLine(dt.ToString("dd-MM-yyy"));
            System.Console.WriteLine(dt.ToString("MM/dd/yy"));
            System.Console.WriteLine(dt.ToString("hh:mm:ss"));

            //construct your own time 
            var mydt = new DateTime(2024,10,07,12,00,00);
            System.Console.WriteLine($"My date and time : {mydt}");

            //calc age from dob 
            System.Console.WriteLine("Enter your Date of Birth as yyyy-mm-dd : ");
            var dob = DateTime.Parse(Console.ReadLine());

            var today = dt.Year;

            var age = dt.Year - dob.Year;
            System.Console.WriteLine(age);



        }
    }
}

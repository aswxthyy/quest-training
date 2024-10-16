// namespace GetSet
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             var s = new Student
//             {
//                 Name = "Alpha",
//                 Age = 200
//             };
//             System.Console.WriteLine(s.Name);
//             System.Console.WriteLine(s.Age);
//         }
//     }
// }
/*
now if you take a look at the Program class, we create an object s of our class Student,
enter values into it.
now, since we have  set
                    {
                        if((value > 0) && (value <50))
                        {
                            age = value;
                        }
                    } 
and set means to store the data, 
if Age  = 200 here our program wont even store the value since it has to be > 0 and < 50
now when s.Age is printed, it displays 0.
try giving another number > 0 and < 50 suppose 25, and it'll print 25
*/

namespace GetSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p = new Person();
            p.Name = "Alpha";
            p.Email = "alpha@gmial.com";

            p.Addresses = new List<Address>();
            p.Addresses.Add(new Address {AddressType = "Home", Line1 = "Church Street", Line2 = "Bangalore", Pincode = "678765"});
            p.Addresses.Add(new Address {AddressType = "Office", Line1 = "Mount Road", Line2 = "Chennai", Pincode = "987665"});

        }
    }
}
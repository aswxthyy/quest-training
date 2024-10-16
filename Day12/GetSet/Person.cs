// namespace GetSet
// {
//     public class Student
//     {
//         public string Name { get; set; } 
//         private int age;

//         public int Age { 
//             get => age; 
//             set
//             {
//                 if((value > 0) && (value <50))
//                 {
//                     age = value;
//                 }
//             } }

//     }
// }
/*
{get; set;} is a 'property' we use in order to impose restrictions while retrieving or saving data
it's possible with functions too but those aren't quite efficcient, hence this property. 
also because some variables may require to be private for security reasons, some maybe only need to be Read Only.
by using {get; set;} the variables are safely exposed to different classes
mishel says it's good practice to declare ALL your data types in this way,
and always declare your private variables in lower case 
public int MyProperty { get; set; }

just type 'prop' and press Tab the rest of it gets autofilled

get() to retreive data
set() to save the data

in Line 5 there aren't any imposed restrictions on Name, we accept and print whatever data the user enters.
in Line 8 for Age we impose restrictions on it, meaning the data is stored only if((value > 0) && (value <50))
value is a keyword here, the user's input value is passed automatically.
{ get; set; } is just expanded as 
{
    get 
    {
        whatever condition
    };
    set
    {
        whatever condition
    };
}

*/

namespace GetSet
{
    public class Person
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Address> Addresses { get; set; } = new List<Address>();

    }

    public class Address
    {
        public string AddressType{ get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Pincode { get; set; }
    
    }
}
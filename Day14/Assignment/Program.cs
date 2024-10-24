namespace Assignment 
{
    1: Define an abstract class called Shape with an abstract method Area().
     Create two derived classes Circle and Rectangle that implement the Area() 
     method for calculating the area of the respective shapes.

    public abstract class Shape
    {
        public abstract double Area();
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area() => 3.14 * Radius * Radius;
    }

    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public override double Area() => Height * Width;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new Circle {Radius = 4};
            var r = new Rectangle {Height = 5, Width = 3};

            Console.WriteLine($"Circle Area: {c.Area()}");
            Console.WriteLine($"Rectangle Area: {r.Area()}");

        }
    }

    2: Create an abstract class Vehicle with a property Speed and an abstract method Drive().
     Implement the Drive() method in two derived classes Car and Bicycle.

    public abstract class Vehicle
    {
        public int Speed { get; set; }
        public abstract void Drive();
    }

    public class Car : Vehicle
    {
        public override void Drive() => System.Console.WriteLine($"Speed of Car : {Speed}");
    }

    public class Bicycle : Vehicle
    {
        public override void Drive() => System.Console.WriteLine($"Speed of Bicycle : {Speed}");

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new Car {Speed = 60};
            var b = new Bicycle {Speed = 15};

            c.Drive();
            b.Drive();
        }
    }

    3: Create an interface IAnimal with a method Speak().
     Implement the interface in two classes Dog and Cat,
      each providing their own implementation of Speak().

    public interface IAnimal
    {
        public void Speak();
    }

    public class Dog : IAnimal
    {
        public void Speak() => System.Console.WriteLine("BOWBOWBOWBOW");
    }

    public class Cat : IAnimal
    {
        public void Speak() => System.Console.WriteLine("meowmeaoewmeow :(");
    }

    internal class Program 
    {
        static void Main(string[] args)
        {
            var d = new Dog();
            d.Speak();
            var c = new Cat();
            c.Speak();
        }
    }

    4: Write an interface ICalculator that has methods Add(int a, int b)
     and Subtract(int a, int b). Implement this interface in a SimpleCalculator class.

    public interface ICalculator
    {
        public int Add(int a, int b);
        public int Subtract(int a, int b);

    }

    public class SimpleCalculator : ICalculator
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new SimpleCalculator();

            System.Console.WriteLine($"Sum : {calc.Add(4,5)}");
            System.Console.WriteLine($"Sum : {calc.Subtract(4,5)}");
        }
    }


    5: Define a delegate Operation that takes two integers as parameters.
     Write methods Add and Multiply that match this delegate signature.
      Demonstrate how to use the delegate to call these methods.

    internal class Program
    {
        public delegate void Operation(int a, int b);
        public static void Add(int a, int b) => System.Console.WriteLine(a+b);
        public static void Multiply(int a, int b) => System.Console.WriteLine(a-b);


        static void Main(string[] args)
        {
            Operation del = Add;
            del += Multiply;
            del += Multiply;
            del -= Multiply;

            del(1,2);
        }
    }



    6: Create a delegate PrintMessage that takes a string as a parameter.
     Write a method DisplayMessage that prints the string passed to it.
      Use the delegate to call DisplayMessage.

    internal class Program 
    {
        public delegate void PrintMessage(string msg);
        public static void DisplayMessage(string msg)
        {
            System.Console.WriteLine(msg);
        }

        static void Main(string[] args)
        {
            PrintMessage del = DisplayMessage;
            del("HELOOOOO");
        }

    }

    7: Define a Func<int, int, int> delegate that takes two integers as parameters and returns their sum.

    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> del = (a, b) => System.Console.WriteLine("$Sum : {a + b}");
            del(5,6);
        }
    }

    8: Write a Func<string, int> delegate that takes a string as input and returns the length of the string.

    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> del = input => input.Length;
            System.Console.WriteLine($"Length : {del("adipoli")}");
        }
    }

    9: Define an Action<string> delegate that prints a string to the console.
     Use this delegate to call a method that prints a welcome message.

    internal class Program
    {
        static void Main(string[] args)
        {
            Action<string> del = message => System.Console.WriteLine(message);
            del("Welcome");
        }
    }

    10: Create an Action<int, int> delegate that takes two integers and prints their sum.

    internal class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> del = (a, b) => System.Console.WriteLine($"Sum : {a + b}");
            del(1,2);
        }
    }

    11: Write a Predicate<int> that checks if a given integer is even.

    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> even = i => i % 2 == 0;
            System.Console.WriteLine(even(4));
        }
    }

    12: Create a Predicate<string> that checks if a given string starts with the letter 'A'.

    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> startswithA = word => word.StartsWith("A");
            System.Console.WriteLine(startswithA("Apple"));
        }
    }

    13: Define an abstract class Appliance with an abstract method TurnOn().
     Create a derived class Fan that implements the TurnOn() method.

    public abstract class Appliance
    {
        public abstract void TurnOn();
    }

    public class Fan : Appliance
    {
        public override void TurnOn() => System.Console.WriteLine("Fan turned On");
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var fan = new Fan();
            fan.TurnOn();
        }
    }

    14: Create an abstract class Person with an abstract method Work().
     Implement Work() in derived classes Doctor and Engineer to describe their specific jobs.

    public abstract class Person
    {
        public abstract void Work();
    }

    public class Doctor : Person
    {
        public override void Work() => System.Console.WriteLine("Treats health issues, Saves lives");
    }

    public class Engineer : Person
    {
        public override void Work() => System.Console.WriteLine("Innovates ideas for the civil");
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Doctor();
            p1.Work();

            var p2 = new Engineer();
            p2.Work();
        }
    }

    15: Write a class Animal with a virtual method MakeSound().
     Create a derived class Dog that overrides MakeSound() to print "Bark!".

    public class Animal
    {
        public virtual void MakeSound()
        {

        }
    }

    public class Dog : Animal
    {
        public override void MakeSound() => System.Console.WriteLine("BAAARRRKKKKKK");
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.MakeSound();
        }
    }
    
    16: Create a base class Employee with a virtual method CalculateBonus().
     In the derived class Manager, override CalculateBonus() to provide a custom calculation.

    public class Employee
    {
        public virtual void CalculateBonus() => System.Console.WriteLine("Employee bonus : 1000");
    }

    public class Manager : Employee
    {
        public override void CalculateBonus() => System.Console.WriteLine("Manager bonus : 3000");
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee();
            emp.CalculateBonus();

            var mgr = new Manager();
            mgr.CalculateBonus();


        }
    }






    

}
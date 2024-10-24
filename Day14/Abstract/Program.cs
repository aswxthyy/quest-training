using System.Threading;
namespace Abstract
{
    abstract class CalculatorBase
    {
        public void Add(int a, int b) => System.Console.WriteLine(a + b);
        public void Sub(int a, int b) => System.Console.WriteLine(a - b);
        public void Mul(int a, int b) => System.Console.WriteLine(a * b);
        public virtual void Div(int a, int b) => System.Console.WriteLine(a / b);
        public abstract void Power(int a, int b);
    }

    class Calculator : CalculatorBase
    {
        public override void Div(int a, int b)
        {
            if(b == 0)
            {
                System.Console.WriteLine("Divide by zero error");
                return;
            }
            base.Div(a,b);
        }

        public override void Power(int a, int b)
        {
            System.Console.WriteLine(Math.Pow(a,b));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            calc.Add(5,10);
            calc.Div(10,0);
            calc.Div(10,2);
            calc.Power(2,3);
        }
    }
}

namespace Abstract
{
    internal class Program 
    {
        static int GetNumber() => 10;
        static string Add(int a, int b) => (a + b).ToString();

        static void Main(string[] args)
        {
            Func<int> gn = GetNumber; //returns only paaram int
            Func<int, int, string> addFunc = Add; // returns last passed paramenter string

            int number = gn(); 
            string result = addFunc(number, 5); 

            Console.WriteLine($"GetNumber: {number}, Add result: {result}");
        }

        static bool IsEven(int n) => n % 2 == 0;
        static void Main(string[] args)
        {
            Func<int, bool> a = IsEven;
            Predicate<int> b = IsEven; //retunrs bool

            var x = a(1);
            var y = b(1);

            Console.WriteLine($"a(1): {x}, b(1): {y}");
        }

        static bool IsEven(int value) → value & 2 = 0;

        enum Type
        {
            Low,
            Medium,
            High
        }

        Type(5)
        
    }

}
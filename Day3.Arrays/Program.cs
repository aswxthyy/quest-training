using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = new int[5];
            Console.Writeline("Enter 5 numbers : ");
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("The numbers multiplied by 2 : ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(numbers[i] * 2);
            }

            System.Console.WriteLine("The sum of the even numbers : ");
            if(numbers[i] % 2 == 0)
            {
                sum += numbers[i];
            }
            Consile.WriteLine(sum);
        }
    }
}
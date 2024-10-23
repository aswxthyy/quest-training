using System;
using System.Collections.Generic;
using System.Linq;

namespace Revision
{
    class MyCustomException : Exception
    {
        public string Message { get; set; }
        public MyCustomException(string message)
        {
            Message = message;
        }
    }
    internal class Program
    {
        // static bool TrimString(ref string data)
        // {
        //     if(data.Length > 5)
        //     {
        //         data = data.Substring(0,5);
        //         return true;
        //     }
        //     return false;
        // }
       static void Main(string[] args)
       {
            // var add = new Calculator();
            // add.Add(2,3);

            // string text = "Hello World";
            // if(TrimString(ref text))
            // {
            //     System.Console.WriteLine(text + "...");
            // }

            // else
            // {
            //         System.Console.WriteLine(text);
            // }

            // try
            // {
            //     System.Console.WriteLine("Enter 2 numbers");
            //     int i = int.Parse(Console.ReadLine());
            //     int j = int.Parse(Console.ReadLine());

            //     System.Console.WriteLine(i/j);
            // }
            // // catch(Exception e)
            // // {
            // //     System.Console.WriteLine(e.Message);
            // //     //System.Console.WriteLine(e.StackTrace);
            // // }
            // catch(OverflowException)
            // {
            //     System.Console.WriteLine("Mumber too large");
            // }
            // catch(DivideByZeroException)
            // {
            //     System.Console.WriteLine("Can't deivide by zero");

            // }
            // catch(FormatException)
            // {
            //     System.Console.WriteLine("Wrong Format");
            // }
            // finally
            // {
            //     System.Console.WriteLine("SO this is printed no matter what. It can be done by just a cw staement outsode the try catch blck but if try is reurn;  is oresent, before the application closes, finally block is prnted");
            // }

            try
            {
                System.Console.WriteLine("Enter 2 numbers");
                int i = int.Parse(Console.ReadLine());
                int j = int.Parse(Console.ReadLine());

                if(j == 0)
                {
                    throw new MyCustomException("Second number can't be zero");
                }

                System.Console.WriteLine(i + j);
                System.Console.WriteLine(i - j);
                System.Console.WriteLine(i * j);
                System.Console.WriteLine(i / j);
            }
            catch(MyCustomException e)
            {
                System.Console.WriteLine(e.Message);
            }
            


       }
    }
}
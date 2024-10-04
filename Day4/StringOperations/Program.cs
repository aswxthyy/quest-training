using System;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
        var res = "";
        res = string.Join(", ","Hello", "World");
        System.Console.WriteLine(res);
        
        var arr = new string[]{"Hi", "World"};
        res = string.Join(", ",arr);
        System.Console.WriteLine(res);

        res = string.Format("{0} {1} {2} and {2}", "Hello", "World", "C#", "C++");
        System.Console.WriteLine(res);

        //String Builder
        var sb = new StringBuilder();
        sb.AppendLine("This is a string builder");
        sb.AppendLine();
        sb.AppendLine("Now there's a blank line");
        res = sb.ToString();
        System.Console.WriteLine(res);
        

        var names = new string[]{"alpha","beta","gamma","delta"};
       
        int index = 0;
        foreach (var name in names)
        {
            sb.AppendFormat("{0} is {1} years old", name, index);
            sb.AppendLine();
            index++; 

            System.Console.WriteLine(sb.ToString()); 
        }    

        //reverse each half of an array
        
        // int[] numbers = {1,2,3,4,5};
        // int mid = numbers[(numbers.Length/2)+1];
        // var firstHalf = numbers.Take(numbers.Length/2).Reverse().ToArray();
        // var secHalf = numbers.Skip(numbers.Length/2 + 1).Reverse().ToArray();

        // firstHalf.CopyTo(numbers,0);
        // secHalf.CopyTo(numbers,numbers.Length/2 + 1);
        // Console.WriteLine(string.Join(" ",numbers));
        

        int[] numbers = {1,2,3,4};
        var firstHalf = numbers.Take(numbers.Length/2).Reverse().ToArray();
        var secHalf = numbers.Skip(numbers.Length/2).Reverse().ToArray();

        firstHalf.CopyTo(numbers,0);
        secHalf.CopyTo(numbers,numbers.Length/2);
        Console.WriteLine(string.Join(" ",numbers));
        */


        /*
        Console.Write("Enter numbers or their names : ");
        var input = Console.ReadLine();

        var sb = new StringBuilder();

        foreach (var i in input)
        {
            switch (i)
            {
                case '1':
                {
                    sb.Append("one");
                    break;
                }                
                case '2':
                {
                    sb.Append("two");
                    break;
                }            
                case '3':
                {
                    sb.Append("three");
                    break;
                }                   
                case '4':
                {
                     sb.Append("four");
                    break;
                }                  
                case '5':
                {
                    sb.Append("five");
                    break;
                }
                default:
                    sb.Append(i); 
                    break;
            }
        }

        Console.WriteLine(sb.ToString());

        //--------------------------------------------
        Console.Write("Enter a string : ");
        var input = Console.ReadLine();

        //Ternary Operator
        //foreach(var i in text)
        //{
        //    char c = char.IsUpper(i) ? char.ToLower(i) : char.ToUpper(i);
        //}

        var sb = new StringBuilder();

        foreach (var i in input)
        {
            char c = i; 
            if ((i >= 'a') && (i <= 'z')) 
            {
                c = (char)(i - 32);
            }
            else if ((i >= 'A') && (i <= 'Z')) 
            {
                c = (char)(i + 32);
            }
            else
                continue;

            sb.Append(c); 
        }

        Console.WriteLine(sb.ToString());
        */
        //----------------------------------
        
        Console.Write("Enter a number : ");
        var input = int.Parse(Console.ReadLine());

        int num = 1;

        for (int i = 1; i <= input; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("{0,4}", num++); 
            }
            Console.WriteLine();
        }
        

        // Console.Write("Enter a number : ");
        // var input = int.Parse(Console.ReadLine());
        

        // for (int i = 1; i <= input; i++)
        // {
        //     for (int j = 1; j <= i; j++)
        //     {
        //         Console.Write(j);
        //     }
        //     Console.WriteLine();
        // }













    }
}
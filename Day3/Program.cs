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
            // int numbers = new int[5];
            // Console.Writeline("Enter 5 numbers : ");
            // int sum = 0;

            // for (int i = 0; i < 5; i++)
            // {
            //     numbers[i] = int.Parse(Console.ReadLine());
            // }

            // System.Console.WriteLine("The numbers multiplied by 2 : ");
            // for (int i = 0; i < 5; i++)
            // {
            //     Console.WriteLine(numbers[i] * 2);
            // }

            // System.Console.WriteLine("The sum of the even numbers : ");
            // if(numbers[i] % 2 == 0)
            // {
            //     sum += numbers[i];
            // }
            // Consile.WriteLine(sum);

            // int[] arr = new int[1];
            // int i = 0;
            // int sum  = 0;

            // while(true)
            // {
            //     System.Console.WriteLine("Enter a number or press Q to quit : ");
            //     string input = Console.ReadLine();
                
            //     if(input.ToUpper == "Q")
            //     {
            //         break;
            //     }

            //     int num = int.Parse(input);

            //     if((num >= 0) && (num <= 9))
            //     {
            //         for(int i = 0; i < num.Length; i++)
            //         {
            //             Array.Resize(ref arr, arr.Length * 2);
            //             sum += arr[i];
            //         }
            //     }

            //     else
            //     {
            //         System.Console.WriteLine($"Sum : {sum}");
            //     }

            // }

            // int[] arr = {1,2,3,4,5,6};
            // int len = arr.Length();

            // for (int i = 0; i < len/2; i++)
            // {
            //     int temp = arr[i];
            //     arr[i] = arr[len - 1 - i];
            //     arr[len - 1 - i] = temp;
            // }
            
            // System.Console.WriteLine(string.Join(",",arr));


            //------------------
            // Console.WriteLine("Enter the number of elements in the array: ");
            // int len = int.Parse(Console.ReadLine());

            // int[] arr = new int[len];
            // Console.WriteLine($"Enter {len} numbers: ");

            // for (int i = 0; i < len; i++)
            // {
            //     arr[i] = int.Parse(Console.ReadLine());
            // }

            
            // int mid = len/2;
            
            // if(len % 2 == 0)
            // {
            //     for (int i = 0; i < mid/2; i++)
            //     {
            //         int temp = arr[i];
            //         arr[i] = arr[len - 1 - i];
            //         arr[len - 1 - i] = temp;
            //     }
                
            //     for (int i = 0; i < mid + (len-mid)/2; i++)
            //     {
            //         int temp = arr[i];
            //         arr[i] = arr[len - 1 - (i-mid)];
            //         arr[len - 1 - (i-mid)] = temp;
            //     }
                
            // }
            
            // else
            // {
            //     for (int i = 0; i < mid/2; i++)
            //     {
            //         int temp = arr[i];
            //         arr[i] = arr[len - 1 - i];
            //         arr[len - 1 - i] = temp;
            //     }
                
            //     for (int i = 0; i < mid + 1 + (len-mid)/2; i++)
            //     {
            //         int temp = arr[i];
            //         arr[i] = arr[len - 1 - (i-mid)];
            //         arr[len - 1 - (i-mid)] = temp;
            //     }
            // }
        
                
            // System.Console.WriteLine(string.Join(",",arr));
            //----------------------






                
        }

        }
    }
}
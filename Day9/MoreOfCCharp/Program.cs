using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreofCSharp
{
    internal class Program
    {
        // static void ChangeDataRefType(MyClass obj) => obj.Data = "New Data"
        // static void ChangeDataValueType(int i) => i = 10;
        static void Main()
        {
            // var obj = new MyClass() { Data = "old Data" };
            // Console.WriteLine($"Before Reference Type Change: {obj. Data}");
            // ChangeDataRefType(obj);
            // Console.WriteLine($"After Reference Type Change: {obj Data}");

            // int i = 5;
            // Console .WriteLine($"Before Value Type Change: {i}");
            // ChangeDataValueType(i);
            // Console. WriteLine($"After Value Type Change: {i}");

            var arr = new int[]{1,2,3,4,5};
            var resize  = 10;

            int[] rearr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                rearr[i] = arr[i];
            }

            arr = rearr;

            for(int i = 0; i < arr.Length; i++)
            {
                System.Console.WriteLine(arr[i]);
            }

            


            
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MoreofCSharp
{
    internal class Program
    {
        static void ChangeDataRefType(MyClass obj) => obj.Data = "New Data"
        static void ChangeDataValueType(int i) => i = 10;
        static void Main(string[] args)
        {
            var obj = new MyClass() { Data = "old Data" };
            Console.WriteLine($"Before Reference Type Change: {obj. Data}");
            ChangeDataRefType(obj);
            Console.WriteLine($"After Reference Type Change: {obj Data}");

            int i = 5;
            Console .WriteLine($"Before Value Type Change: {i}");
            ChangeDataValueType(i);
            Console. WriteLine($"After Value Type Change: {i}");
        }
    }
}

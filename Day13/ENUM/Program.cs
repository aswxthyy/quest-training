using System;
using System.IO;
using System.Collections.Generic;

namespace ENUM
{
    internal class Program 
    {
        public enum ConvertTo
        {
            Upper,
            Lower,
            Swapcase
        }

        public static void ConvertCasing(string input, ConvertTo targetType)
        {
            switch(targetType)
            {
                case ConvertTo.Upper:
                    System.Console.WriteLine(input.ToUpper());
                    break;
                case ConvertTo.Lower:
                    System.Console.WriteLine(input.ToLower());
                    break;

            }
        }
        static void Main()
        {
            ConvertCasing("Heloo", ConvertTo.Lower);
        }
    }
}

namespace ENUM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path  = @"/Users/aswathy/Documents/Mishel's Notes";
            var fileName  = "data.txt";
            var filePath = Path.Combine(path, fileName);
            Directory.CreateDirectory(path);
            File.Delete()
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        string myString = "  Hello, World!  ";

        // string.Length: Gets the length of the string.  
        int length = myString.Length;       
        Console.WriteLine(length);             // 15
        
        // string.ToLower(): Converts all characters to lowercase.
        string lowercase = myString.ToLower();          
        Console.WriteLine(lowercase);         // "  hello, world!  "
       
       // string.ToUpper(): Converts all characters to uppercase.
        string uppercase = myString.ToUpper();      
        Console.WriteLine(uppercase);         // "  HELLO, WORLD!  "    

        // string.Trim(): Removes whitespace from the beginning and end.
        string trimmed = myString.Trim();                
        Console.WriteLine(trimmed);           // "Hello, World!"

        // string.Split(char[]): Splits the string into an array using specified delimiters.
        string[] splitString = myString.Split(new[] { ',' }); 
        Console.WriteLine(string.Join(", ", splitString)); // "  Hello", " World!  "

        // string.Join(string, IEnumerable<string>): Joins elements of a string array into a single string using a specified separator.
        string joinedString = string.Join(" - ", splitString);
        Console.WriteLine(joinedString);      // "  Hello -  World!  "

        // string.Replace(string, string): Replaces occurrences of a substring with another substring.
        string replacedString = myString.Replace("World", "C#");
        Console.WriteLine(replacedString);    // "  Hello, C#!  "

        // string.IndexOf(string): Returns the index of the first occurrence of a substring; returns -1 if not found.
        int indexOfSubstring = myString.IndexOf("lo"); 
        Console.WriteLine(indexOfSubstring);  // 8

        // string.StartsWith(string): Checks if the string starts with the specified prefix.
        bool startsWith = myString.StartsWith("  He");  
        Console.WriteLine(startsWith);        // True

        // string.EndsWith(string): Checks if the string ends with the specified suffix.
        bool endsWith = myString.EndsWith("!");        
        Console.WriteLine(endsWith);          // True          
       
        
    }
}

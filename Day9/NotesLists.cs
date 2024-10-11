using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // 1. Add() -  Adds an object to the end of the list.
        List<int> numbers = new List<int>();
        numbers.Add(5);
        numbers.Add(10);
        numbers.Add(15);
        Console.WriteLine("List after Add():");
        PrintList(numbers);

            //List after adding elements:1,2,3


        // 2. AddRange() - Adds the elements of the specified collection to the end of the list.
        List<int> moreNumbers = new List<int> { 20, 25 };
        numbers.AddRange(moreNumbers);
        Console.WriteLine("List after AddRange():");
        PrintList(numbers);

            //List after adding range:1,2,3,4,5,6


        // 3. Remove() - Removes the first occurrence of a specific object from the list
        numbers.Remove(10);  // Removes the first occurrence of 10
        Console.WriteLine("List after Remove(10):");
        PrintList(numbers);

           // List after removing 2:1,3,2,4


        // 4. RemoveAt() - Removes the element at the specified index.
        numbers.RemoveAt(2);  // Removes the element at index 2
        Console.WriteLine("List after RemoveAt(2):");
        PrintList(numbers);

           // List after removing element at index 1:1,3,4


        // 5. Insert() - Inserts an element into the list at the specified index.
        numbers.Insert(1, 30);  // Inserts 30 at index 1
        Console.WriteLine("List after Insert(30) at index 1:");
        PrintList(numbers);

               // List after inserting 2 at index 1:1,2,3,4

        // 6. Count - Returns the number of elements in the list
        int count = numbers.Count;
        Console.WriteLine("Number of elements in the list: " + count);

            //Number of elements in the list: 3


        // 7. Contains() - Determines whether the list contains a specific value.
        bool containsFive = numbers.Contains(5);
        Console.WriteLine("List contains 5: " + containsFive);

            //List contains 2: True


        // 8. IndexOf() - Returns the zero-based index of the first occurrence of a specific item in the list.
        int indexOfThirty = numbers.IndexOf(30);
        Console.WriteLine("Index of 30: " + indexOfThirty);

            //Index of 2: 1


        // 9. Clear() - Removes all elements from the list
        numbers.Clear();
        Console.WriteLine("List after Clear():");
        PrintList(numbers);  // Should print nothing, as the list is empty

            //List after clearing: 0


        // 10. Sort() - Sorts the elements in the entire list using the default comparer.
        numbers.AddRange(new List<int> { 3, 1, 4, 2 });
        numbers.Sort();  // Sorts the list
        Console.WriteLine("List after Sort():");
        PrintList(numbers);

            //Sorted list:1,2,3,4

    }
}
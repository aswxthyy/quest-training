Sort :
Sorts the elements in an array.
int[] numbers = { 3, 1, 4, 1, 5, 9 };
Array.Sort(numbers);
// numbers is now { 1, 1, 3, 4, 5, 9 }

Reverse : 
Reverses the order of elements in an array.
Array.Reverse(numbers);
// numbers is now { 9, 5, 4, 3, 1, 1 }

Array.Resize : 
Changes the size of an array.
Array.Resize(ref numbers, 10);
// numbers length is now 10

Array.IndexOf :
Finds the index of a specific element.
int index = Array.IndexOf(numbers, 4);
// index is 2

Array.Copy :
Copies elements from one array to another.
int[] destination = new int[5];
Array.Copy(numbers, destination, 5);
// destination contains the first 5 elements of numbers

Array.Clear :
Clears the values of elements in an array.
Array.Clear(numbers, 0, numbers.Length);
// all elements in numbers are now 0

Array.Find :
Finds the first element that matches a condition.
int[] numbers = { 3, 1, 4, 1, 5, 9 };
int result = Array.Find(numbers, element => element > 3);
// result is 4

Array.Exists: : 
Checks if any elements match a condition.
bool exists = Array.Exists(numbers, element => element > 6);
// exists is true

Array.FindAll :
Finds all elements that match a condition.
int[] results = Array.FindAll(numbers, element => element > 3);
// results is { 4, 5, 9 }

Array.TrueForAll :
Checks if all elements match a condition.
bool allGreaterThanZero = Array.TrueForAll(numbers, element => element > 0);
// allGreaterThanZero is true

Array.ForEach :
Applies an action to each element of an array.
Array.ForEach(numbers, element => Console.WriteLine(element));

Array.FindIndex :
Finds the index of the first element that matches a condition.
int index = Array.FindIndex(numbers, element => element > 3);
// index is 2

Array.FindLast :
Finds the last element that matches a condition.
int lastResult = Array.Find(numbers, element => element > 2);
// lastResult is 5 (assuming numbers were { 1, 2, 3, 4, 5 })

Array.FindLastIndex :
Finds the index of the last element that matches a condition.
int lastFindIndex = Array.FindLastIndex(numbers, element => element > 2);
// lastFindIndex is 4
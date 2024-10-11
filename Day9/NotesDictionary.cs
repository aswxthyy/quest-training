1.Add()
Adds a new key-value pair to the dictionary. If the key already exists, it throws an exception.

CODE:
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> products = new Dictionary<int, string>();
        products.Add(1, "Laptop");
        products.Add(2, "Mobile");
        Console.WriteLine("Product added successfully.");
    }
}


OUTPUT:
Product added successfully.



2.ContainsKey()
Checks if the dictionary contains a specific key. It returns true if the key exists, otherwise false.

Example:
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> products = new Dictionary<int, string>();
        products.Add(1, "Laptop");
        products.Add(2, "Mobile");

        if (products.ContainsKey(1))
        {
            Console.WriteLine("Key found in dictionary.");
        }
        else
        {
            Console.WriteLine("Key not found.");
        }
    }
}


OUTPUT:
Key found in dictionary.



3.Remove()
Removes the key-value pair with the specified key from the dictionary. It returns true if the key is found and removed, otherwise false.

EXAMPLE:
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> products = new Dictionary<int, string>();
        products.Add(1, "Laptop");
        products.Add(2, "Mobile");

        bool isRemoved = products.Remove(2);
        if (isRemoved)
        {
            Console.WriteLine("Product removed successfully.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }
}


OUTPUT:
Product removed successfully.



4.TryGetValue()
Tries to get the value associated with the specified key. This method prevents exceptions if the key doesn't exist, and instead returns false.

EXAMPLE:
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        Dictionary<int, string> products = new Dictionary<int, string>();

        products.Add(1, "Laptop");
        products.Add(2, "Mobile");

        string productName;
        if (products.TryGetValue(1, out productName))
        {
            Console.WriteLine($"Product found: {productName}");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }

        if (products.TryGetValue(3, out productName))
        {
            Console.WriteLine($"Product found: {productName}");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }
}


OUTPUT:
Product found: Laptop
Product not found.



5. Clear()
Removes all key-value pairs from the dictionary.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> products = new Dictionary<int, string>();
        products.Add(1, "Laptop");
        products.Add(2, "Mobile");

        products.Clear();
        Console.WriteLine("All products removed.");
    }
}

OUTPUT:
All products removed.



6. Count
Returns the number of key-value pairs in the dictionary. This is a property, not a method.

EXAMPLE:
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> products = new Dictionary<int, string>();
        products.Add(1, "Laptop");
        products.Add(2, "Mobile");

        Console.WriteLine($"Total products: {products.Count}");
    }
}

OUTPUT:
Total products: 2



7. Keys
Gets a collection of all the keys in the dictionary.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> products = new Dictionary<int, string>();
        products.Add(1, "Laptop");
        products.Add(2, "Mobile");

        foreach (int key in products.Keys)
        {
            Console.WriteLine($"Product ID: {key}");
        }
    }
}

OUTPUT:
Product ID: 1
Product ID: 2



8. Values
Gets a collection of all the values in the dictionary.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> products = new Dictionary<int, string>();
        products.Add(1, "Laptop");
        products.Add(2, "Mobile");

        foreach (string value in products.Values)
        {
            Console.WriteLine($"Product Name: {value}");
        }
    }
}

OUTPUT:
Product Name: Laptop
Product Name: Mobile



9. Indexer []
Allows direct access to dictionary elements using keys. You can use this to get or set values.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> products = new Dictionary<int, string>();
        products.Add(1, "Laptop");
        products.Add(2, "Mobile");

        Console.WriteLine(products[1]);
        products[1] = "Updated Laptop";
        Console.WriteLine(products[1]);
    }
}

OUTPUT:
Laptop
Updated Laptop



10. ContainsValue()
Checks if the dictionary contains a specific value.

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> products = new Dictionary<int, string>();
        products.Add(1, "Laptop");
        products.Add(2, "Mobile");

        if (products.ContainsValue("Laptop"))
        {
            Console.WriteLine("The product is available.");
        }
        else
        {
            Console.WriteLine("The product is not available.");
        }
    }
}

OUTPUT:
The product is available.


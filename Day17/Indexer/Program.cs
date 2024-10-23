/*
namespace Indexer
{
    internal class Program
    {
        class ShoppingList
        {
            private string[] _items = new string[10];
            public string this[int index]
            {
                get => _items[index];
                set {_items[index] = value;}
            }
            public int TotalItems => _items.Count(i => i != null);
        }
        static void Main(string[] args)
        {
            var list = new ShoppingList();
            list[0] = "apple";
            list[1] = "banana";
            System.Console.WriteLine(list[0]);
            System.Console.WriteLine(list.TotalItems);
        }
    }
}
*/

namespace Indexer
{
    internal class Program
    {
        class ShoppingList
        {
            private List<string> _items = new List<string>();
            public string this[int index]
            {
                get
                {
                    if(index >= _items.Count)
                    {
                        throws new IndexOutOfRangeException("Index out of Range");
                    }
                    return _items[index]
                }
                set
                {
                    if(index >= _items.Count)
                    {
                        _items.Add(value)
                    }
                    else
                    {
                        _items[index] = value;
                    }
                }
            }
            public int TotalItems => _items.Count;
        }
        static void Main(string[] args)
        {
            try
            {
                var list = new ShoppingList();
                list[0] = "apple";
                list[1] = "banana";
                System.Console.WriteLine(list[0]);
                System.Console.WriteLine(list.TotalItems);
            }
            catch
            {

            }
           
        }
    }
}
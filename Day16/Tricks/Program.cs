using System;
using System.Collection;
using System.Collections.Generic;
namespace Tricks
{
    class Dictionary<TKey, TValue>
    {
        private Dictionary<TKey,TValue> _data = new Dictionary<TKey, TValue>();
        //public int Count => _data.Count;
        public void Add(TKey key, TValue value)
        {
            _data.Add(key, value);
        }
    }

    internal class Program
    {
        // static int Calc(bool doAdd, int a, int b)
        // {
        //     return doAdd ? a + b : a - b;
        // }
        static void Main(string[] args)
        {
            var numD = new Dictionary<int, int>();
            numD.Add(5,7);

            var strD = new Dictionary<string, string>();
            strD.Add("Hello", "World");
            // var res = Calc(true, 2, 3);
            // System.Console.WriteLine(res);

            // var lst = new List<string>();
            // lst.Add("ONE");
            // lst.Add("THREE");
            // System.Console.WriteLine(lst[0].ToLower);

            // var alist = new ArrayList();
            // alist.Add(2);
            // alist.Add("THREE");
            // System.Console.WriteLine(alist[0]);

            // Hashtable ht = new Hashtable();
            // ht.Add("ONE", 1);
            // ht.Add("THREE", 3);
            // System.Console.WriteLine(ht["ONE"]);
        }
    }
}
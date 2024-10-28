/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Threading
{
    internal class Program 
    {
        static void Action1()
        {
            Thread.Sleep(2000);
            System.Console.WriteLine("This is Action1");
        }
        static void Action2()
        {
            System.Console.WriteLine("This is Action2");
        }
        static void Main(string[] args)
        {
            var t1 = new Thread(Action1);
            var t2 = new Thread(Action2);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            System.Console.WriteLine("Completed");
            
            int[] arr = { 1, 2, 3, 4, 5 }; // newer versions
            Span<int> span = arr;

            for (int i = 0; i < span.Length; i++)
            {
                System.Console.WriteLine(span[i]);
            }
        }
    }
}
*/

using BenchmarkDotNet.Running;
using ConsoleAppCore;

BenchmarkRunner.Run<ArrayAndSpan>();
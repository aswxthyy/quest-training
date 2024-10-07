using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    static class Program
    {
        public static void Main(string[] args)
        {
            // List<int> lst = new List<int>();

            // lst.Add(10);
            // lst.Add(20);
            // lst.Add(30);

            // var valuesToAdd = new int[]{10,20,30,40,50};
            // lst.AddRange(valuesToAdd);

            // lst[0] = 100;

            // lst.Remove(50);

            // lst.RemoveAt(1);

            // for(int i  = 0; i < lst.Count; i++)
            // {
            //     Console.Write(lst[i]+",");
            // }

            //-----------------------------------

            // List<int> oddeven = new List<int>();
            // for(int i = 0; i < 5; i++)
            // {
            //     System.Console.WriteLine($"Enter number {i} ");
            //     oddeven.Add(int.Parse(Console.ReadLine()));
            // }

            // for(int i = 0; i < oddeven.Count; i++)
            // {
            //     if(i % 2 == 0)
            //     {
            //         oddeven.RemoveAt(i);
            //     }
            // }

            // Console.Write(string.Join(',',oddeven));

            //-----------------------------------

            // var marks = new List<int>();
            // //var marks  = new List<List<int>>();
            
            // for(int i = 0; i < 5; i++)
            // {
            //     for(int j = 0; j < 3; j++)
            //     {
            //         Console.WriteLine($"Enter marks of student {i} ");
            //         marks.Add(int.Parse(Console.ReadLine()));
            //     }
               
            // }

            // Console.WriteLine("Marks :");
            // for(int i = 0; i < 5; i++)
            // {
            //     Console.Write($"Student {i + 1} : ");
            //     for(int j = 0; j < 3; j++)
            //     {
            //         Console.Write(j + " ");
            //     }
            //     Console.WriteLine(); 
            // }

            // var input = new List<List<int>>();

            // for(int i = 0; i < 2; i++)
            // {
            //     var marks = new List<int>();
            //     for(int j = 1; j <= 3; j++)
            //     {
            //         Console.Write("Enter the marks ");
            //         int mark = int.Parse(Console.ReadLine());

            //         marks.Add(mark);
            //     }
            //     input.Add(marks);
            // }
            // Console.ReadLine();
            //---------------------------

            int[] input = new int[100];

            for(int i = 0; i < 2; i++)
            {
                var marks = new List<int>();

                Console.WriteLine("Enter the number of subjects : ");
                var s = int.Parse(Console.ReadLine());

                for(int j = 1; j <= s; j++)
                {
                    Console.Write("Enter the marks ");
                    int mark = int.Parse(Console.ReadLine());

                    marks.Add(mark);
                }
                input.Add(marks);
            }

        }
    }
}

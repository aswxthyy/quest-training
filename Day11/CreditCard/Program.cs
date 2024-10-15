using System;
using System.Collections.Generic;

namespace CreditCard
{
    internal class Program
    {
        private static CardManager cardManager = new CardManager();
        static void Main(string[] args)
        {
            while(true)
            {
                System.Console.WriteLine("WELCOME");
                System.Console.WriteLine("1. Add New Card    2.Search for Card");
                System.Console.WriteLine("3. Update Card     4. Delete a Card");
                System.Console.WriteLine("5. Exit");
                string opt = Console.ReadLine();

                switch(opt)
                {
                    case "1":
                    {
                        cardManager.AddCard();
                        break;
                    }
                    case "2":
                    {
                        cardManager.SearchCard();
                        break;
                    }
                    case "3":
                    {
                        cardManager.UpdateCard();
                        break;
                    }
                    case "4":
                    {
                        cardManager.DeleteCard();
                        break;
                    }
                    case "5":
                    {
                        return;
                    }
                    default:
                    {
                        System.Console.WriteLine("Enter a valid input");
                        break;
                    }
                }
            }
        }
    }
}
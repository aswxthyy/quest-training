using System;
using System.Collections.Generic;

namespace CreditCard
{
    class CardManager
    {
        Dictionary<string, Dictionary<string, object>> cards = new Dictionary<string, Dictionary<string, object>>();

        public void AddCard()
        {
            System.Console.WriteLine("Card Number (ADD) : ");
            string cardNo = Console.ReadLine();

            if(cards.ContainsKey(cardNo))
            {
                System.Console.WriteLine("Card already exists");
            }

            else
            {
                var cardDetails = new Dictionary<string, object>();

                System.Console.WriteLine("Card Holder Name : ");
                cardDetails.Add("Name", Console.ReadLine());

                System.Console.WriteLine("Expiry Month : ");
                cardDetails.Add("ExpMonth", Console.ReadLine());

                System.Console.WriteLine("Expiry Year : ");
                cardDetails.Add("ExpYear", Console.ReadLine());

                System.Console.WriteLine("CVV : ");
                cardDetails.Add("CVV", Console.ReadLine());

                cards[cardNo] = cardDetails;
                System.Console.WriteLine("Card Details Added");

            }
        }

        public void SearchCard()
        {
            System.Console.WriteLine("Card Number (SEARCH) : ");
            string searchNo = Console.ReadLine();

            if(cards.ContainsKey(searchNo))
            {
                var cardNum = cards[searchNo];

                System.Console.WriteLine($"Card Number : {searchNo}");
                System.Console.WriteLine($"Card Holder Name : {cardNum["Name"]}");
                System.Console.WriteLine($"Expiry Month : {cardNum["ExpMonth"]}");
                System.Console.WriteLine($"Expiry Year : {cardNum["ExpYear"]}");
                System.Console.WriteLine($"CVV : {cardNum["CVV"]}");
            }
            else
            {
                System.Console.WriteLine("Card does not exist");
            }
        }

        public void UpdateCard()
        {
            System.Console.WriteLine("Card Number (UPDATE) : ");
            string updateNo = Console.ReadLine();

            if(cards.ContainsKey(updateNo))
            {
                System.Console.WriteLine("New card holder name : ");
                string newName = Console.ReadLine();
                cards[updateNo]["Name"] = newName;

                System.Console.WriteLine("Extended Expiry Month : ");
                string newMonth = Console.ReadLine();
                cards[updateNo]["ExpMonth"] = newMonth;

                System.Console.WriteLine("Extended Expiry Year : ");
                string newYear = Console.ReadLine();
                cards[updateNo]["ExpYear"] = newYear;

                System.Console.WriteLine("Card Updation Successful");

            }
            else 
            {
                System.Console.WriteLine("Card does not exist");
            }
        }

        public void DeleteCard()
        {
            System.Console.WriteLine("Card Number (DELETE) : ");
            string delNo = Console.ReadLine();

            if(cards.ContainsKey(delNo))
            {
                cards.Remove(delNo);
                System.Console.WriteLine("Card Deleted");
            }
            else
            {
                System.Console.WriteLine("Card does not exist");
            }
        }
    }
}
using System;
using System.Linq;
using System.Collections.Generic;

namespace ListJoins
{
    // class Accounts
    // {
    //     public int ID { get; set; }
    //     public string Name { get; set; }
    //     public int Balance { get; set; }
    // }

    // class Transactions
    // {
    //     public int TransID { get; set; }
    //     public int FromAccID { get; set; }
    //     public int ToAccID { get; set; }
    //     public int Amount { get; set; }
    //     public DateTime Date { get; set; }
    // }

    internal class Program
    {
        static void Main(string[] args)
        {
            // var accs = new List<Accounts>()
            // {
            //     new Accounts{ID = 1, Name = "Alpha", Balance = 1000},
            //     new Accounts{ID = 2, Name = "Beta", Balance = 2100},
            //     new Accounts{ID = 3, Name = "Gamma", Balance = 3000}
            // };

            // var trans = new List<Transactions>()
            // {
            //     new Transactions{TransID = 101, FromAccID = 1, ToAccID = 2, Amount = 500, Date = DateTime.Now},
            //     new Transactions{TransID = 102, FromAccID = 2, ToAccID = 3, Amount = 100, Date = DateTime.Now},
            //     new Transactions{TransID = 103, FromAccID = 3, ToAccID = 1, Amount = 30, Date = DateTime.Now},
            // };

            // var bank = accs
            //             .Join(
            //                 trans,
            //                 a => a.ID,
            //                 t => t.FromAccID,
            //                 (a, t) => new
            //                 {
            //                     Amount = t.Amount,
            //                     From = a.Name,
            //                     To = t.ToAccID,
            //                     Date = t.Date
            //                 }
            //             );
            // foreach(var i in bank)
            // {
            //     System.Console.WriteLine($"Rs.{i.Amount} transferred from {i.From} to {i.To} on {i.Date}");
            // }                    

            // TUPLES

            (int, int) data = (2, 3);
            System.Console.WriteLine(data.Item1);
            System.Console.WriteLine(data.Item2);

            (int num1, int num2) numbers = (1, 2);
            System.Console.WriteLine(numbers.num1);
            System.Console.WriteLine(numbers.num2);


            var res = AddAndSub(10,5);
            System.Console.WriteLine(res.add);
            System.Console.WriteLine(res.sub);

        }

        static (int add, int sub) AddAndSub(int a, int b)
        {
            return(a + b, a - b);
        }
    }
}
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnLinq
{
    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
    }

    public class Transaction
    {
        public int Id { get; set; }
        public int FromAccountId { get; set; }
        public int ToAccountId { get; set; }
        public DateTime DateTime { get; set; }
        public int Amount { get; set; }
    }
    internal class Program
    {
        static void Main()
        {
            var accounts = new List<Account>
            {
                new Account {Id = 1, Name = "Alice", Balance = 1000},
                new Account {Id = 2, Name = "Bob", Balance = 2000},
                new Account {Id = 3, Name = "Charlie", Balance = 1500}
            };

            var transactions = new List<Transaction>
            {
                new Transaction {Id = 1, FromAccountId = 1, ToAccountId = 2, DateTime = DateTime.Now.AddHours(-2), Amount = 200},
                new Transaction {Id = 2, FromAccountId = 2, ToAccountId = 3, DateTime = DateTime.Now.AddHours(-1), Amount = 300},
                new Transaction {Id = 3, FromAccountId = 3, ToAccountId = 1, DateTime = DateTime.Now.AddMinutes(-30), Amount = 100}
            };

            var tr = from transaction in transactions
                     join fromAccount in accounts on transaction.FromAccountId equals fromAccount.Id
                     join toAccount in accounts on transaction.ToAccountId equals toAccount.Id
                     select new
                     {
                        TransactionId = transaction.Id,
                        FromAccountName = fromAccount.Name,
                        ToAccountName = toAccount.Name,
                        Amount = transaction.Amount,
                        Date = transaction.DateTime
                     };

            var transactionDetails = transactions
                .Join(
                    accounts,
                    t => t.FromAccountId,
                    a => a.Id,
                    (transaction, account) => new {Transaction = transaction, FromAccount = account})
                .Join(
                    accounts,
                    res => res.Transaction.ToAccountId,
                    a => a.Id,
                    (res, toAccount) => new
                    {
                        TransactionId = res.Transaction.Id,
                        FromAccountName = res.FromAccount.Name,
                        ToAccountName = toAccount.Name,
                        Amount = res.Transaction.Amount,
                        Date = res.Transaction.DateTime
                    });

            foreach(var item in transactionDetails)
            {
                System.Console.WriteLine($"From: {item.FromAccountName}, To: {item.ToAccountName}, Amount: {item.Amount}, Date: {item.Date}");
            }
        }
    }
}
*/
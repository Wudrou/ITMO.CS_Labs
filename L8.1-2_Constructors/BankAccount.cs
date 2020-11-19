using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L8._1_2_Constructors
{
    enum AccountType
    {
        Checking,
        Deposit
    }
    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        private static long nextAccNo = 123;
        private Queue tranQueue = new Queue();
        public BankAccount()
        {
            accNo = NextNumber();
            accType = AccountType.Checking;
            accBal = 0;
        }
        public BankAccount(AccountType aType)
        {
            accNo = NextNumber();
            accType = aType;
            accBal = 0;
        }
        public BankAccount(decimal aBal)
        {
            accNo = NextNumber();
            accType = AccountType.Checking;
            accBal = aBal;
        }
        public BankAccount(AccountType aType, decimal aBal)
        {
            accNo = NextNumber();
            accType = aType;
            accBal = aBal;
        }
        public long Number()
        {
            return accNo;
        }
        public decimal Balance()
        {
            return accBal;
        }
        public string Type()
        {
            return accType.ToString();
        }
        private static long NextNumber()
        {
            return nextAccNo++;
        }
        public decimal Deposit(decimal amount)
        {
            accBal += amount;
            BankTransaction tran = new BankTransaction(amount);
            tranQueue.Enqueue(tran);
            return accBal;
        }
        public bool Withdraw(decimal amount)
        {
            bool sufficientFunds = accBal >= amount;
            if (sufficientFunds)
            {
                accBal -= amount;
                BankTransaction tran = new BankTransaction(-amount);
                tranQueue.Enqueue(tran);
            }
            return sufficientFunds;
        }
        public Queue Transactions()
        {
            return tranQueue;
        }
        //public void TransferFrom(BankAccount accFrom, decimal amount)
        //{
        //    if (accFrom.Withdraw(amount))
        //    {
        //        this.Deposit(amount);
        //    }
        //}
        static void Write(BankAccount acc)
        {
            Console.WriteLine("Account number is {0}", acc.Number());
            Console.WriteLine("Account balance is {0}", acc.Balance());
            Console.WriteLine("Account type is {0}", acc.Type());
            Console.WriteLine("Transactions:");
            foreach (BankTransaction tran in acc.Transactions())
            {
                Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
            }
            Console.WriteLine();
        }
        static void Main()
        {
            BankAccount acc1;

            acc1 = new BankAccount();

            acc1.Deposit(100);
            acc1.Withdraw(50);
            acc1.Deposit(75);
            acc1.Withdraw(50);
            acc1.Withdraw(30);
            acc1.Deposit(40);
            acc1.Deposit(200);
            acc1.Withdraw(250);
            acc1.Deposit(25);

            Write(acc1);

            Console.ReadKey();
        }
    }
}

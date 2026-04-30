using System.Net.Cache;

namespace DotNet_task1
{

    abstract class BankAccount
    {
        protected int accountNumber , accounttype;
        protected double balance;

        
        protected BankAccount (int accountNumber, int type)
        {
            this.accountNumber = accountNumber;
            balance = 0;
        }
        public void add_balance(int amount)
        {
            balance += amount;  
        }
        public abstract void withdraw_balance(double amount);
       

    }
    class SavingAccount : BankAccount
    {
       public SavingAccount (int accountNumber) : base(accountNumber,1)
        {
        }

        public override void withdraw_balance(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }


    }

    class currentAccount : BankAccount
    {
        public currentAccount(int accountNumber) : base(accountNumber,2)
        {
        }
        public override void withdraw_balance(double amount)
        {
            if (balance >= amount + amount * 0.05)
            {
                balance -= (amount + amount * 0.05);
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
    }

        internal class Program
    {
        void withdraw_balance(BankAccount account, int val)
        {
          account.withdraw_balance(val);
        }

        static void Main(string[] args)
        {
            BankAccount Ali = new SavingAccount(12345);
            Ali.add_balance(1000);

        }
    }
}

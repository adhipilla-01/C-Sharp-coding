namespace Constructors
{
    internal class BankAccount
    {
        string? AccountHolderName;
        string? AccountNumber;
        double Balance;
        public BankAccount(string? accountHolderName, string accountNumber, double balance)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
            Balance = balance;
        }
        public BankAccount(BankAccount Obj)
        {
            AccountHolderName = Obj.AccountHolderName;
            AccountNumber = Obj.AccountNumber;
            Balance = Obj.Balance;
        }
        public void DisplayAccountInfo()
        {
            Console.WriteLine("\nAccount Details : \n-----------------");
            Console.WriteLine("Account Holder Name : " + AccountHolderName);
            Console.WriteLine("Account Number      : " + AccountNumber);
            Console.WriteLine("Account Balance     : " + Balance);
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Amount must be greater than Zero");
                return;
            }
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Sucessfully completed withdrawl process");
            }
            else Console.WriteLine("Insufficient Balance");
        }

        public static void Main()
        {
            Console.Write("Enter Account Holder Name : ");
            string? AccountHolderName = Console.ReadLine();
            Console.Write("Enter Account Number : ");
            string? AccountNumber = Console.ReadLine();
            Console.Write("Enter Account Balance : ");
            double Balance = Convert.ToDouble(Console.ReadLine());
            BankAccount Details = new BankAccount(AccountHolderName, AccountNumber, Balance);
            BankAccount Details1 = new BankAccount(Details);
            Details.DisplayAccountInfo();
            Details1.DisplayAccountInfo();
            Console.Write("\nEnter Amount to Deposit : ");
            double DAmount = Convert.ToDouble(Console.ReadLine());
            Details.Deposit(DAmount);
            Console.WriteLine("\nAfter Updating Balance : ");
            Details.DisplayAccountInfo();
            Console.Write("\nEnter Amount to Withdraw : ");
            double WAmount = Convert.ToDouble(Console.ReadLine());
            Details.Withdraw(WAmount);
            Console.WriteLine("\nAfter Withdrawl : ");
            Details.DisplayAccountInfo();
            Console.WriteLine("\nCopy Constructor values After doing all the Transactions : ");
            Details1.DisplayAccountInfo();

            Console.ReadKey();
        }
    }
}

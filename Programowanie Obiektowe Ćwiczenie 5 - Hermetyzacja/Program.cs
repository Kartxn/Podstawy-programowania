using System;

public class BankAccount
{
    private string accountNumber;
    
    private decimal balance;
    
    public BankAccount(string accountNumber, decimal initialBalance)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }
    
    public string GetAccountNumber()
    {
        return accountNumber;
    }
    
    public decimal GetBalance()
    {
        return balance;
    }
    
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Wpłata {amount:C} zakończona sukcesem.");
        }
        else
        {
            Console.WriteLine("Kwota wpłaty musi być większa od zera.");
        }
    }
    
    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Wypłata {amount:C} zakończona sukcesem.");
        }
        else if (amount > balance)
        {
            Console.WriteLine("Niewystarczające środki na koncie.");
        }
        else
        {
            Console.WriteLine("Kwota wypłaty musi być większa od zera.");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = null;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Create a new bank account");
                Console.WriteLine("2. Manage existing bank account");
                Console.WriteLine("3. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                Console.Clear();

                switch (choice)
                {
                    case "1":
                        account = CreateBankAccount();
                        break;
                    case "2":
                        if (account != null)
                        {
                            ManageBankAccount(account);
                        }
                        else
                        {
                            Console.WriteLine("No account created yet.");
                        }
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        static BankAccount CreateBankAccount()
        {
            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();
            Console.Write("Enter initial balance: ");
            decimal initialBalance = decimal.Parse(Console.ReadLine());

            BankAccount account = new BankAccount(accountNumber, initialBalance);

            Console.WriteLine("Account created successfully!");
            Console.WriteLine($"Account Number: {account.GetAccountNumber()}");
            Console.WriteLine($"Initial Balance: {account.GetBalance():C}");

            return account;
        }

        static void ManageBankAccount(BankAccount account)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Account Number: {account.GetAccountNumber()}");
                Console.WriteLine($"Current Balance: {account.GetBalance():C}");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Back to main menu");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                Console.Clear();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter deposit amount: ");
                        decimal depositAmount = decimal.Parse(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;
                    case "2":
                        Console.Write("Enter withdrawal amount: ");
                        decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
                        account.Withdraw(withdrawalAmount);
                        break;
                    case "3":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
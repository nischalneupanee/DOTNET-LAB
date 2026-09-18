using System;

abstract class BankAccount
{
    public string AccountNumber { get; set; }
    public string AccountHolderName { get; set; }
    public double Balance { get; set; }

    public BankAccount(string accNum, string holderName, double balance)
    {
        AccountNumber = accNum;
        AccountHolderName = holderName;
        Balance = balance;
    }

    public abstract double CalculateInterest();

    public void Display()
    {
        Console.WriteLine($"Acc No: {AccountNumber}, Holder: {AccountHolderName}, Balance: ${Balance:F2}");
        Console.WriteLine($"Calculated Interest: ${CalculateInterest():F2}\n");
    }
}

class SavingAccount : BankAccount
{
    private double interestRate = 0.05; // 5% annual interest

    public SavingAccount(string accNum, string holderName, double balance)
        : base(accNum, holderName, balance) { }

    public override double CalculateInterest()
    {
        return Balance * interestRate;
    }
}

class CurrentAccount : BankAccount
{
    private double interestRate = 0.01; // 1% maintenance interest

    public CurrentAccount(string accNum, string holderName, double balance)
        : base(accNum, holderName, balance) { }

    public override double CalculateInterest()
    {
        return Balance * interestRate;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("=== Bank Account Interest Calculation ===");

        BankAccount sa = new SavingAccount("SA-1001", "Rohan Shrestha", 50000);
        BankAccount ca = new CurrentAccount("CA-2001", "Apex Enterprises", 150000);

        sa.Display();
        ca.Display();
    }
}

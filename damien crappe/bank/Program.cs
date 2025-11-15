using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        var owner1 = new Person("Aaron", "Crappe", new DateTime(2020, 1, 7));
        var owner2 = new Person("Taylor", "Swifer", new DateTime(2001, 2, 26));

        var bank = new Bank("Ma Banque");

        var currentAccount = new CurrentAccount("123445", owner1, 1500.0, 100.0);
        var currentAccount2 = new CurrentAccount("987654", owner2, 2000.0, 500.0);
        var savingsAccount = new SavingsAccount("968365", owner1, 10000.0);
        var savingsAccount2 = new SavingsAccount("563248", owner2, 5000.0);

        bank.AddAccount(currentAccount);
        bank.AddAccount(currentAccount2);
        bank.AddAccount(savingsAccount);
        bank.AddAccount(savingsAccount2);

        var methods = new Methods();

        methods.ShowMoney(currentAccount);

        currentAccount.ApplyInterest();
        Console.WriteLine($"Après intérêts, le solde du compte de {currentAccount.Owner} est de {currentAccount.Balance} EUR.");

        try
        {
            currentAccount.Withdraw(1_000_000); // devrait déclencher une InsufficientBalanceException
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Erreur de solde : " + ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine("Erreur de montant : " + ex.Message);
        }
    }
}

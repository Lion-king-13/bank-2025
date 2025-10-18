using System;
using System.Dynamic;
using System.Globalization;

class Person
{
    public string FirstName;
    public string LastName;
    public DateTime BirthDate;
}
class CurrentAccount
{
    public string Number;
    public double Balance { get; }
    public double CreditLine;
    public Person Owner;
    public void Deposit(double amount, double Balance)
    {
        Balance += amount;
    }
    public void Withdraw(double amount, double Balance)
    {
        Balance -= amount;
    }
}
class Bank
{
    public readonly Dictionary<string, CurrentAccount> Accounts = [];
    public string Name;
    public void AddAccount(CurrentAccount account)
    {
        Accounts[account.Number] = account;
    }
    public void RemoveAccount(string accountNumber)
    {
        Accounts.Remove(accountNumber);
    }

}
class Methods
{
    public void ShowMoney(CurrentAccount account)
    {
        Console.WriteLine($"Le compte {account.Number} a un solde de {account.Balance} euros.");
    }
    public void ShowMoneySum(Bank bank, Person owner)
    {
        double SumAccount = 0;
        foreach (var account in bank.Accounts.Values)
        {
            if (account.Owner == owner)
            {
                SumAccount += account.Balance;
            }
        }
        Console.WriteLine($"La somme des comptes de {owner.FirstName} {owner.LastName} est de {SumAccount} euros.");
    }
}
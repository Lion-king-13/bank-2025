class Bank
{
    public readonly Dictionary<string, Account> Accounts = new ();
    public string Name;
    public Bank(string name)
    {
        Name = name;
    }
    public void AddAccount(Account account)
    {
        Accounts[account.Number] = account;
        return;
    }
    public void RemoveAccount(string accountNumber)
    {
        Accounts.Remove(accountNumber);
        return;
    }

}

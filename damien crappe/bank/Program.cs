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
}

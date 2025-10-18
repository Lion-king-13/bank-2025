using System;
using System.Collections.Generic; 
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        List<Person> people = new List<Person>
        {
            new Person("John", "Doe", new DateTime(1990, 5, 24)),
            new Person("Jane", "Smith", new DateTime(1985, 10, 12)),
            new Person("Alice", "Johnson", new DateTime(2000, 3, 8))
        };

        foreach (var person in people)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}, Born on: {person.BirthDate.ToString("d", CultureInfo.InvariantCulture)}");
        }
    }
}

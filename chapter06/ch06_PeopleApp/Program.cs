using System;
using Packt.CS7;
using static System.Console;


namespace ch06_PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person();
            p1.Name = "Bob Smith";
            p1.DateOfBirth = new DateTime(1965, 12, 22);
            p1.FavoriteAncientWonder = WondersOfTheAncientWorld.GreatPyramidOfGiza;
            p1.Children.Add(new Person());
            p1.Children.Add(new Person());


            WriteLine($"{p1.Name} was born on {p1.DateOfBirth}");
            WriteLine($"{p1.Name} was born on {p1.DateOfBirth:dddd, d MMMM yyyy}");
            WriteLine($"{p1.Name}'s favorite wonder is {p1.FavoriteAncientWonder}");
            WriteLine($"{p1.Name} has {p1.Children.Count} children.");

            // - OR - 
            var p2 = new Person { Name = "Alice Jones", DateOfBirth = new DateTime(1988, 4, 14) };
            WriteLine($"{p2.Name} was born on {p1.DateOfBirth:dddd, d MMMM yyyy}\n");

            // using static fields
            BankAccount.InterestRate = 0.012M; 
            var ba1 = new BankAccount(); 
            ba1.AccountName = "Mrs. Jones"; 
            ba1.Balance = 2400; 
            WriteLine($"{ba1.AccountName} earned {ba1.Balance * BankAccount.InterestRate:C} interest."); 

            var ba2 = new BankAccount(); 
            ba2.AccountName = "Ms. Gerrier"; 
            ba2.Balance = 98; 
            WriteLine($"{ba2.AccountName} earned {ba2.Balance * BankAccount.InterestRate:C} interest.");

            // using constant fields -- Avoid if possible
            WriteLine($"{p1.Name} is a {Person.Species}");

            // using read-only fields -- Preferred over const
            WriteLine($"{p1.Name} was born on {p1.HomePlanet}");

            // calling the constructor
            var p3 = new Person();
            WriteLine($"{p3.Name} was instatiated at {p3.Instantiated:hh:mm:ss} on {p3.Instantiated:dddd, MMM d yyyy}");

            // calling the second constructor
            var p4 = new Person("Aziz");
            WriteLine($"{p4.Name} was instatiated at {p4.Instantiated:hh:mm:ss} on {p4.Instantiated:dddd, MMM d yyyy}");

        }
    }
}
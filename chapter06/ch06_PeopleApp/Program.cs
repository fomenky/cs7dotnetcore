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

            // calling methods 
            p1.WriteToConsole();
            WriteLine(p1.GetOrigin());

            // calling tuples
            var fruitNamed = p1.GetNamedFruit();
            WriteLine($"Are there {fruitNamed.Number} {fruitNamed.Name}?");

            // deconstructing tuples
            (string fruitName, int fruitNumber) = p1.GetFruitCS7();
            WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

            // For more on deconstruction of data types see: https://docs.microsoft.com/en-us/dotnet/articles/csharp/tuples#deconstruction
            
            // calling param in methods
            WriteLine(p2.SayHello());
            WriteLine(p2.SayHello("Emily"));

            // using optional params
            p1.OptionalParameters();
            p1.OptionalParameters(number: 52.7, command: "Hide!");
            p1.OptionalParameters("Poke!", active: false);
            
            // Controlling parameter flow in methods
            int a = 10;
            int b = 20;
            int c = 30;
            WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            p1.PassingParameters(a, ref b, out c);
            WriteLine($"After: a = {a}, b = {b}, c = {c}");
        
            // simplified C# 7 syntax for out parameters 
            int d = 10; 
            int e = 20; 
            WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet!"); 
            p1.PassingParameters(d, ref e, out int f); 
            WriteLine($"After: d = {d}, e = {e}, f = {f}");

            // calling read-only properties
            var max = new Person { Name = "Max", DateOfBirth = new DateTime(1972, 1, 27) };
            WriteLine(max.Origin);
            WriteLine(max.Greeting);
            WriteLine(max.Age);

            // calling getter & setter properties
            max.FavoriteIceCream = "Chocolate Fudge";   // setter 
            WriteLine($"Max's favorite ice-cream flavor is {max.FavoriteIceCream}");    // getter

            max.FavoritePrimaryColor = "Red";   // setter
            WriteLine($"Max's favorite primary color is {max.FavoritePrimaryColor}");   // getter

            // calling indexers
            max.Children.Add(new Person { Name = "Charlie" }); 
            max.Children.Add(new Person { Name = "Ella" }); 
            WriteLine($"Max's first child is {max.Children[0].Name}"); 
            WriteLine($"Max's second child is {max.Children[1].Name}"); 
            WriteLine($"Max's first child is {max[0].Name}"); 
            WriteLine($"Max's second child is {max[1].Name}");
        }
    }
}
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


            WriteLine($"{p1.Name} was born on {p1.DateOfBirth}");
            WriteLine($"{p1.Name} was born on {p1.DateOfBirth:dddd, d MMMM yyyy}");
            WriteLine($"{p1.Name}'s favorite wonder is {p1.FavoriteAncientWonder}");

            // - OR - 
            var p2 = new Person { Name = "Alice Jones", DateOfBirth = new DateTime(1988, 4, 14) };
            WriteLine($"{p2.Name} was born on {p1.DateOfBirth:dddd, d MMMM yyyy}");
        }
    }
}
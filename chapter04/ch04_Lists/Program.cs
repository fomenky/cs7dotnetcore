using System;
using System.Collections.Generic;
using static System.Console;


namespace ch04_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new List<string>();
            cities.Add("London");
            cities.Add("Paris");
            cities.Add("Milan");
            WriteLine("Initial List");
            foreach (string city in cities)
            {
                WriteLine($"  {city}");
            }
            WriteLine($"The first city is {cities[0]}.");  
            WriteLine($"The last city is {cities[cities.Count - 1]}.");
            
            cities.Insert(0, "Sydney");
            WriteLine("After inserting Sydney at index 0"); 
            foreach (string city in cities) 
            { 
             WriteLine($"  {city}"); 
            } 
        }
    }
}

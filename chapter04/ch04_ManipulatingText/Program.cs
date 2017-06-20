using System;
using static System.Console;

namespace ch04_ManupulatingText
{
    class Program
    {
        static void Main(string[] args)
        {
            // Getting length of string
            string city = "London";
            WriteLine($"{city} is {city.Length} characters long.");

            // Getting # chars in string
            WriteLine($"First char is {city[0]} and third is {city[2]}.");

            // Spitting a string
            string cities = "Paris,Berlin,Madrid,New York";
            string[] citiesArray = cities.Split(',');
            foreach (string item in citiesArray)
            {
                WriteLine(item);
            }

            // Getting Part of a string
            string fullname = "Alan Jones";
            int indexOfTheSpace = fullname.IndexOf(' ');
            string firstname = fullname.Substring(0, indexOfTheSpace);
            string lastname = fullname.Substring(indexOfTheSpace + 1);
            WriteLine($"{lastname}, {firstname}");

            // Change input from Jones, Alan to Alan Jones
            string fullName = "Jones, Alan";
            string[] nameArray = fullName.Split(',');
            WriteLine($"{nameArray[1]} {nameArray[0]}");    

            // Checking string for content
            string company = "Microsoft";
            bool startsWithM = company.StartsWith('M');
            bool containsN = company.Contains("N");
            WriteLine($"Starts with M: {startsWithM}, contains an N: {containsN}");

            // recombine an array of strings
            string recombined = string.Join(" => ", citiesArray);
            WriteLine(recombined);

            // Other String MEMBERS to mess around with include:
            /*
            Trim, TrimStart, and TrimEnd: These trim whitespaces from the beginning and/or end of the string.
            ToUpper and ToLower: These convert the string into uppercase or lowercase.
            Insert and Remove: These insert or remove some text in the string.
            Replace: This replaces some text.
            String.Concat: This concatenates two string variables. The + operator calls this method when used between string variables.
            String.Join: This concatenates one or more string variables with a character in between each one.
            String.IsEmptyOrNull: This checks whether a string is empty ("") or null.
            String.Empty: This can be used instead of allocating memory each time you use a literal string value using an empty pair of double quotes ("").
             */



        }
    }
}

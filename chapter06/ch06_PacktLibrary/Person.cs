using System;
using System.Collections.Generic;
using static System.Console;


namespace Packt.CS7
{
    public partial class Person
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public List<Person> Children = new List<Person>();
        public const string Species = "Homo Sapien";

        // read-only fields
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        // Constructors | multiple is needed
        public Person() {
            // set default values for fields
            // including readonly fields
            Name = "Unkown";
            Instantiated = DateTime.Now;
        }
        public Person(string initialName){
            Name = initialName;
            Instantiated = DateTime.Now;
        }
        // methods
        public void WriteToConsole(){
            WriteLine($"{Name} was born on {DateOfBirth:dddd, d MMMM YYYY}");
        }
        public string GetOrigin(){
            return $"{Name} was born on {HomePlanet}";
        }
        // tuples
        // the old c# 4.0 System.Tuple type
        public Tuple<string, int> GetFruitCS4(){
            return Tuple.Create("Apples", 5);
        }
        // the new c# 7 System.ValueTuple type
        public (string, int) GetFruitCS7(){
            return ("Apples", 5);
        }
        public (string Name, int Number) GetNamedFruit(){
            return (Name: "Apples", Number: 5);
        }
        // Passing Params/Arguments
        public string SayHello(){
            return $"{Name} says 'Hello!'";
        }
        // Overload method
        public string SayHello(string name){
            return $"{Name} says 'Hello {name}!'";
        }
        // optional Parameters
        public void OptionalParameters(string command = "Run!", double number = 0.0, bool active = true){
            WriteLine($"command is {command}, number is {number}, active is {active}");
        }
        // Controlling how parameters are passed
        public void PassingParameters(int x, ref int y, out int z) 
        { 
            // out parameters cannot have a default  
            // AND must be initialized inside the method 
            z = 30; 
        
            // increment each parameter 
            x++; // default -- in-only
            y++; // ref -- in-and-out
            z++; 
        } 
    }
}
using System;
using System.Collections.Generic;

namespace Packt.CS7
{
    public class Person
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

    }
}
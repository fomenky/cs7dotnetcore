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

    }
}

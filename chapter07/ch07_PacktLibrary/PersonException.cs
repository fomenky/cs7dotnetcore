using System;
using static System.Console;

namespace Packt.CS7
{
    public class PersonException : Exception
    {
        public PersonException() : base() { } 
        public PersonException(string message) : base(message) { } 
        public PersonException(string message, Exception innerException) : base( 
          message, innerException) { } 
    }
    // When defining your own exceptions, give them the same three constructors.
}
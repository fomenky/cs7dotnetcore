using System;
using static System.Console;
using System.Text.RegularExpressions;

namespace ch04_RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter your age: "); 
            string input = ReadLine(); 
            Regex ageChecker = new Regex(@"^\d$"); // (@"^\d$") - Allows ONE digit only | (@"^\d+$") - Allows TWO digits | (@"^\d*$") - Allows only digits
            if (ageChecker.IsMatch(input))
            {
                WriteLine("Thank you!");
            }else
            {
                WriteLine($"This is not a valid age: {input}");
            }
            
            // Regular Expression Syntax
            /*
            ^   - Start of input
            $   - End of input
            \d  - A single digit
            \D  - A single NON-digit
            \w  - Whitespace
            \W  - NON-whitespace
            [A-Za-z0-9] - Range(s) of characters
            [AEIOU] - Set of characters
            +   - One or more
            ?   - One or none
            .   - A single character
            {3} - Exactly three
            {3,5} - Three to five
            {3,}  - Three or more
            {,3}  - Up to three
             */

             // Examples
             /*
             ^\d{2}$    - Exactly two digits.
             ^[0-9]{2}$ - Exactly two digits.
             ^[A-Z]{4,}$ - At least four uppercase letters only.
             ^[A-Za-z]{4,}$ - At least four upper or lowercase letters only.
             ^[A-Z]{2}\d{3}$ - Two uppercase letters and three digits only.
             ^d.g$      - The letter d, then any character, and then the letter g, so it would match both dig and dog or any characters between the d and g.
             ^d\.g$     - The letter d, then a dot (.), and then the letter g, so it would match d.g only.
              */

              // NB: Use Regular Expressions to validate input from a user
        }
    }
}

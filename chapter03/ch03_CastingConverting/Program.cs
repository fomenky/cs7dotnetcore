using System;
using static System.Console;
using static System.Convert;

namespace ch03_IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
          // Casting NUMBERS
          int a = 10;
          double b = a;   // An int can be stored as a double

          double c = 9.8;
          //int d = c;    // This will fail since you can't cast a double as an int since its unsafe & might result to data loss
          int d = (int)c; // d is losing a digit .8 for this EXPLICIT CAST to // work
          Console.WriteLine(b);
          Console.WriteLine(d);

          long e = 10;
          int f = (int)e;
          Console.WriteLine($"e is {e} and f is {f}");

          e = long.MaxValue;
          f = (int)e;
          Console.WriteLine($"e is {e} and f is {f}");  // Here we lose data
                                                        // because any vaulue too big gets set to -1!
          double g = 9.8;
          int h = ToInt32(g);
          Console.WriteLine($"g is {g} and h is {h}\n");

          // Rounding Rules
          // NB: //One difference between casting and converting is that converting rounds the double value up to 10 instead of trimming the part after the decimal point.
          double i = 9.49;
          double j = 9.5;
          double k = 10.49;
          double l = 10.5;

          Console.WriteLine("CASTING");
          WriteLine($"i is {i}, ToInt(i) is {(int)(i)}");
          WriteLine($"j is {j}, ToInt(j) is {(int)(j)}");
          WriteLine($"k is {k}, ToInt(k) is {(int)(k)}");
          WriteLine($"l is {l}, ToInt(l) is {(int)(l)}\n");

          Console.WriteLine("CONVERTING");
          WriteLine($"i is {i}, ToInt(i) is {ToInt32(i)}");
          WriteLine($"j is {j}, ToInt(j) is {ToInt32(j)}");
          WriteLine($"k is {k}, ToInt(k) is {ToInt32(k)}");
          WriteLine($"l is {l}, ToInt(l) is {ToInt32(l)}\n");

          // CONVERTING ToString()
          Console.WriteLine($"CONVERTING ToString()");
          int number = 12;
          WriteLine(number.ToString());
          bool boolean = true;
          WriteLine(boolean.ToString());
          DateTime now = DateTime.Now;
          WriteLine(now.ToString());
          object me = new object();
          WriteLine($"{me.ToString()}\n");

          // Parsing
          Console.WriteLine($"PARSING");
          int age = int.Parse("27");
          DateTime birthday = DateTime.Parse("4 July 1980");
          WriteLine($"I was born {age} years ago.");
          WriteLine($"My birthday is {birthday}.");
          WriteLine($"My birthday is {birthday:D}.\n");

          //int count = int.Parse("abc");
          // To Avoid errors with the Parse method, use TryParse instead
          Write("How many eggs are there? ");
          int count;
          string input = Console.ReadLine();
          if (int.TryParse(input, out count)) // The out keyword is required to allow the TryParse method to set the count variable when the conversion works.
          {
            WriteLine($"There are {count} eggs.");
          }
          else
          {
            WriteLine("I could not parse the input.");
          }


        }
    }
}

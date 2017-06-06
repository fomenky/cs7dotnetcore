using System;
using static System.Console;

namespace ch03_IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
          // while statements
          int x = 0;
          while (x < 10)
          {
            WriteLine(x);
            x++;
          }

          // do statements
          string password = string.Empty;
          do
          {
            Write("Enter your password: ");
            password = ReadLine();
          } while (password != "secret");
          WriteLine("Correct!");

        }
    }
}

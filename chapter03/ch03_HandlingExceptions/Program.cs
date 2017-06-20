using System;
using System.IO;
using static System.Console;

namespace ch03_HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
          // Handling Exceptions
          // The try Statement
          Console.WriteLine($"Before parsing");
          Write($"what is your age? ");
          string input = Console.ReadLine();
          try {
              int age = int.Parse(input);
              Console.WriteLine($"You are {age} years old.");
          }catch (FormatException) {
            Console.WriteLine("The age you enter was not a valid number format");
          }
          catch (Exception unkown){
            Console.WriteLine($"{unkown.GetType()} says {unkown.Message}");
          }
          Console.WriteLine($"After Parsing");

          // The finally Statement
          // string path = /home/ac/Documents/git-repos/cs-repo/cs7dotnetcore/chapter03
          string path = @"/home/ac/Documents/git-repos/cs-repo/cs7dotnetcore/chapter03";
          FileStream file = null;
          StreamWriter writer = null;
          try {
            if (Directory.Exists(path)) {
              file = File.OpenWrite(Path.Combine(path, "file2.txt"));
              writer = new StreamWriter(file);
              writer.WriteLine("Hello AceDeamon, you're just adding text to file2.txt");
            }else{
              Console.WriteLine($"{path} does not exists");
            }
          }
          catch (Exception ex) {
            // if the path doesn't exist the exception will be caught
            Console.WriteLine($"{ex.GetType()} says {ex.Message}");
          }
          finally  {
            if (writer != null) {
              writer.Dispose();
              Console.WriteLine("The writer's unmanaged resources have been disposed");
            }if (file != null) {
              file.Dispose();
              Console.WriteLine("The file's unmanaged resources have been disposed");
            }
          }
          // The using Statement -- Simplifies Disposing Code
          using (FileStream file3 = File.OpenWrite(Path.Combine(path, "file3.txt"))){
            using (StreamWriter writer3 = new StreamWriter(file3)){
              try {
                writer3.WriteLine("Welcome, .Net Core!");
              }
              catch (Exception ex) {
                Console.WriteLine($"{ex.GetType} says {ex.Message}");
              } // No finally method required Here
            }   // using automatically calls the Dispose if the object is not null
          }

          /* //LINKS//
          Selection Statements (C# Reference): https://docs.microsoft.com/en-us/dotnet/articles/csharp/language-reference/keywords/selection-statements
          Iteration Statements (C# Reference): https://docs.microsoft.com/en-us/dotnet/articles/csharp/language-reference/keywords/iteration-statements
          Jump Statements (C# Reference): https://docs.microsoft.com/en-us/dotnet/articles/csharp/language-reference/keywords/jump-statements
          Casting and Type Conversions (C# Programming Guide): https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/types/casting-and-type-conversions
          Exception Handling Statements (C# Reference): https://docs.microsoft.com/en-us/dotnet/articles/csharp/language-reference/keywords/exception-handling-statements
          StackOverflow: http://stackoverflow.com/
          Google Advanced Search: http://www.google.com/advanced_search
          .NET Blog: https://blogs.msdn.microsoft.com/dotnet/
          What .NET Developers ought to know to start in 2017:  https://www.hanselman.com/blog/WhatNETDevelopersOughtToKnowToStartIn2017.aspx
          CoreFX README.md: https://github.com/dotnet/corefx/blob/master/Documentation/README.md
          Design Patterns: https://msdn.microsoft.com/en-us/library/ff649977.aspx
          patterns & practices: https://msdn.microsoft.com/en-us/library/ff921345.aspx

          */


        }
    }
}

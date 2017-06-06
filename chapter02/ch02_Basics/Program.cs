using System;
using System.Linq;
using System.Reflection;

namespace ch02_Basics
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// loop through the assemblies that this application references 
			foreach (var r in Assembly.GetEntryAssembly()
			  .GetReferencedAssemblies())
			{
				// load the assembly so we can read its details 
				var a = Assembly.Load(new AssemblyName(r.FullName));
				// declare a variable to count the total number of methods 
				int methodCount = 0;
				// loop through all the types in the assembly 
				foreach (var t in a.DefinedTypes)
				{
					// add up the counts of methods 
					methodCount += t.GetMethods().Count();
				}
				// output the count of types and their methods 
				Console.WriteLine($"{a.DefinedTypes.Count():N0} types " +
				  $"with {methodCount:N0} methods in {r.Name} assembly.");
			}

			//Making a value type nullable
			Console.WriteLine($"{default(int)}");   // will return 0
			Console.WriteLine($"{default(bool)}");  // will return false
			Console.WriteLine($"{default(DateTime)}"); // 1/01/0001 00:00:00 

			//Allowing a value type to be null
			int ICannotBeNull = 4;
			int? ICouldBeNull = null;
			Console.WriteLine(ICouldBeNull.GetValueOrDefault()); // returns 0
			ICouldBeNull = 5;
			Console.WriteLine(ICouldBeNull.GetValueOrDefault()); // returns 5

			//Checking for NULL before using NULLABLE variable
			if (ICouldBeNull != null)
			{
				//do something
			}

			//Get value from nullable variable
			string authorName = null;
			// if authorName is null, instead of throwing an exception, 
			// null is returned
			int? howManyLetters = authorName?.Length;
			Console.WriteLine(howManyLetters);

			//Null-coalescing operator (??) -- Assign Either OR based on value
			var result = howManyLetters ?? 3;
			Console.WriteLine(result);  // result will be three IF howManyLetters is null


			//****** | Arrays | ALWAYS OF FIXED SIZE********
			//Storing multiple values in an array
			string[] names = new string[4];
			// storing items at index positions
			names[0] = "Kate";
			names[1] = "Jack";
			names[2] = "Rebecca";
			names[3] = "Tom";
			for (int i = 0; i < names.Length; i++)
			{
				Console.WriteLine(names[i]); // read the item at this index 
			}

			//Getting Input In a Console App
			Console.Write("Type your first name and press ENTER: ");
			string firstName = Console.ReadLine();

			Console.Write("Type your age and press ENTER: ");
			string age = Console.ReadLine();

			Console.WriteLine($"Hello {firstName}, you look good for {age}.");

			//Passing Arguments
			//args[0] = "red";
			//args[1] = "yellow";
			//args[2] = "Two";
			//args[3] = "Three";

			//var ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[0], true);

			//var BackgroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), args[1], true);

			//int WindowWidth = int.Parse(args[2]);

			//int WindowHeight = int.Parse(args[3]);

			Console.WriteLine($"There are {args.Length} arguments.");
			foreach (var arg in args)
			{
				Console.WriteLine(arg);
			}

			Console.WriteLine($"There are {args.Length} arguments");

			//C# Keywords: https://docs.microsoft.com/en-us/dotnet/articles/csharp/language-reference/keywords/index
			//Main() and Command-Line Arguments(C# Programming Guide):  https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/main-and-command-args/
			//Types(C# Programming Guide):  https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/types/
			//Statements, Expressions, and Operators(C# Programming Guide):  https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/statements-expressions-operators/
			//Strings(C# Programming Guide):  https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/strings/
			//Nullable Types(C# Programming Guide): https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/nullable-types/
			//Console Class: https://msdn.microsoft.com/en-us/library/system.console(v=vs.110).aspx
			//C# Operators: https://msdn.microsoft.com/en-us/library/6a71f45d.aspx

		}
	}
}

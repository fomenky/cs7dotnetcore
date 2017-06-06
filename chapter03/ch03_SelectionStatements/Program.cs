using System;
using System.IO;
using static System.Console;

namespace ch03_SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //if-else
            if (args.Length == 0) {
              Console.WriteLine("There are no arguments");
            }else{
              Console.WriteLine("There is at least one argument.");
            }

            object o = 3;
            int j = 4;

            if (o is int i) {
              WriteLine($"{i} x {j} = {i * j}");
            }else{
              WriteLine("o is not an int so it cannot multiply!");
            }

            //switch statements
            A_label:
              var number = (new Random()).Next(1,7);
              WriteLine($"My random number is {number}"); //print number
              switch (number) {
                case 1:
                  Console.WriteLine("one");
                  break; // jump to the end of the switch statement
                case 2:
                  Console.WriteLine("two");
                  goto case 1;
                case 3:
                case 4:
                  Console.WriteLine("three or four");
                  goto case 1;
                case 5:
                  // go to sleep for half a second
                  System.Threading.Thread.Sleep(500);
                  goto A_label;
                default:
                  Console.WriteLine("default");
                  break;
              } // end of switch statement

              // Pattern matching with the switch statement
              //string path = /home/ac/Documents/git-repos/cs-repo/cs7dotnetcore/chapter03/
              string path = @"/home/ac/Documents/git-repos/cs-repo/cs7dotnetcore/chapter03/";
              Stream s = File.Open(Path.Combine(path, "file.txt"), FileMode.OpenOrCreate);

              switch(s) {
                case FileStream writeableFile when s.CanWrite:
                  WriteLine("The stream is to a file that I can write to.");
                  break;
                case FileStream readOnlyFile:
                  WriteLine("The stream is to a read-only file.");
                  break;
                case MemoryStream ms:
                  WriteLine("The stream is to a memory address.");
                  break;
                default: // always evaluated last despite its current position
                  WriteLine("The stream is some other type.");
                  break;
                case null:
                  WriteLine("The stream is null.");
                  break;
                }
                // NB: FileStream & MemoryStream are SubTypes of Stream

                
        }
    }
}

using static System.Console;
using System.IO;
using System.Threading;
using static System.IO.Directory;

namespace ch10_FileSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // define a directory path
            // string dir = @"C:\Users\AceGod\Documents\repos\cs7dotnetcore\chapter10\ch10_Example" // Windows
            string dir = @"C:\Users\AceGod\Documents\repos\cs7dotnetcore\chapter10\ch10_Example";

            // check if it exists
            WriteLine($"Does {dir} exist? {Exists(dir)}");
            // create directory
            CreateDirectory(dir);
            WriteLine($"Does {dir} exist? {Exists(dir)}");
            // delete directory
            Delete(dir);
            WriteLine($"Does {dir} exist? {Exists(dir)}");

            // define a file path
            WriteLine();
            // string textFile = @"C:\Users\AceGod\Documents\repos\cs7dotnetcore\chapter10\ch10_file.txt"
            // string backupFile = @"C:\Users\AceGod\Documents\repos\cs7dotnetcore\chapter10\ch10_file.bak"
            string textFile = @"C:\Users\AceGod\Documents\repos\cs7dotnetcore\chapter10\ch10_file.txt";
            string backupFile = @"C:\Users\AceGod\Documents\repos\cs7dotnetcore\chapter10\ch10_file.bak";

            // check if file exists
            WriteLine($"Does {textFile} exists? {File.Exists(textFile)}");

            // create a new text file and write a line to it
            StreamWriter textWriter = File.CreateText(textFile);
            textWriter.WriteLine("Hello, C#!");
            textWriter.Dispose();
            WriteLine($"Does {textFile} exists? {File.Exists(textFile)}");

            // copy a file and overwrite if it already exists 
            File.Copy(textFile, backupFile, true); 
            WriteLine($"Does {backupFile} exist? {File.Exists(backupFile)}");

            // delete a file 
            File.Delete(textFile); 
            WriteLine($"Does {textFile} exist? {File.Exists(textFile)}"); 

            // Read a text file 
            StreamReader textReader = File.OpenText(backupFile);
            WriteLine(textReader.ReadToEnd());
            textReader.Dispose();            
        }
    }
}

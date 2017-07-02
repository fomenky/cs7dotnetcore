using System;
using static System.Console;

using System.Linq;


namespace ch09_LinqToObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new string[]{"Michael", "Pam", "Jim", "Dwight", "Angela", "Kevin", "Toby", "Creed"};
            var query = names.Where(name => name.Length > 4);
            //var query = names.Where(NameLongerThanFour); // Another way of doing it 
            // var query = names.Where(new Func<string, bool>(NameLongerThanFour)); // longer way of doing it

            // Sorting with OrderBy & ThenBy -- for multiple properties
            var query_sort = names
                .Where(name => name.Length > 4)
                .OrderBy(name => name.Length)
                .ThenBy(name => name); 
                
            foreach (var item in query)
            {
                WriteLine(item);
            }
        }
        static bool NameLongerThanFour(string name){
            return name.Length > 4;
        }
    }
}

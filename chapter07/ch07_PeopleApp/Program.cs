using System;
using Packt.CS7;
using static System.Console;

namespace ch07_PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var harry = new Person{ Name = "Harry"};
            var mary = new Person{ Name = "Mary"};
            var baby1 = harry.Procreate(mary);
            // using * operator defined in Person class 
            var baby2 = harry * mary; // same as code above -- Use ONLY when try to simplify your code or defining new functions for operators

            WriteLine($"{mary.Name} has {mary.Children.Count} children");
            WriteLine($"{harry.Name} has {harry.Children.Count} children");
            WriteLine($"{harry.Name}'s first child is named \"{harry.Children[0].Name}\"");
            WriteLine($"5! is {harry.Factorial(5)}");

            // Events
            harry.Shout += Harry_Shout;
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();

            // Using the most common interface -- IComparable
            Person[] people = 
            {
                new Person { Name = "Simon" },
                new Person { Name = "Jenny" },
                new Person { Name = "Adam" },
                new Person { Name = "Richard" },
            };
            WriteLine("Initial list of people:"); 
            foreach (var person in people) 
            { 
                WriteLine($"{person.Name}"); 
            }

            WriteLine("Use Person's sort implementation:"); 
            Array.Sort(people); // ICOmparable Must be implemented in Person class for this work
            foreach (var person in people) 
            { 
                WriteLine($"{person.Name}"); 
            }
            // calling structs
            var dv1 = new DisplacementVector(3, 5);
            var dv2 = new DisplacementVector(-2, 7);
            var dv3 = dv1 + dv2;
            WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X}, {dv3.Y})");

            // Implementing Inheritance
            Employee e1 = new Employee{
                Name = "John Doe",
                DateOfBirth = new DateTime(1990, 7, 28)
            };
            e1.WriteToConsole();
            e1.EmployeeCode = "JJ001"; 
            e1.HireDate = new DateTime(2014, 11, 23); 
            WriteLine($"{e1.Name} was hired on {e1.HireDate:dd/MM/yy}");

            // Polymorphism
            Employee aliceInEmployee = new Employee{
                Name = "Alice", 
                EmployeeCode = "AA123"
            };
            Person aliceInPerson = aliceInEmployee; // This is implicit casting
            //Employee e2 = (Employee)aliceInPerson;  // This is explicit casting

            aliceInEmployee.WriteToConsole();
            aliceInPerson.WriteToConsole(); 
            // when hidden w/ the new keyword, the compiler is not smart enough to know that the object is an employee
            
            WriteLine(aliceInEmployee.ToString());
            WriteLine(aliceInPerson.ToString()); 
            //When a method is overridden with virtual and override, the compiler is smart enough to know that although the variable is declared as a Person class, the object itself is an Employee and, therefore, the Employee implementation of ToString is called.

            // Handling casting exceptions
            if (aliceInPerson is Employee) 
            { 
                WriteLine($"{nameof(aliceInPerson)} IS an Employee"); 
                Employee e2 = (Employee)aliceInPerson; 
                // do something with e2 
            } 
            // Explicit Casting using the 'as' keyword
            Employee e3 = aliceInPerson as Employee;    
            if (e3 != null) 
            { 
                WriteLine($"{nameof(aliceInPerson)} AS an Employee"); 
                // do something with e3 
            }
            // Calling Derived exceptions
            try
            {
                e1.TimeTravel(new DateTime(1999, 12, 31));
                e1.TimeTravel(new DateTime(1950, 12, 25));
            }
            catch (PersonException ex)
            {
                WriteLine(ex.Message);
            }

            // Using personalized extensions
            string email1 = "pamela@test.com";
            string email2 = "ian&test.com";

            WriteLine(email1.GetType());

            WriteLine($"{email1} is a valid e-mail address: {email1.IsValidEmail()}."); 
            WriteLine($"{email2} is a valid e-mail address: {email2.IsValidEmail()}.");
            WriteLine("Great job! We just extended a sealed class --> System.String!");
        }

        // Calling Events
        public static void Harry_Shout(object sender, EventArgs e){
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }
    }
}

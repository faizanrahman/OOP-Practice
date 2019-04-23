using System;

namespace OOP_Practice
{


    // Basic Inheritance Practice - Includes overriding methods and calling base constructor
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Employee emp1 = new Employee("Fahad","Rahman");
            //emp1.PrintFullName();
            //PartTimeEmployee pte = new PartTimeEmployee("Faizan","Rahman",24);
            //pte.PrintFullName();
            //Console.WriteLine(pte.FirstName);
            //Console.WriteLine(pte.LastName);
            //Console.WriteLine(pte.HourlyRate);

            FullTimeEmployee fte = new FullTimeEmployee("Fahad", "Rahman", 51000);
            fte.PrintFullName();
            Console.WriteLine(fte.Salary);
        }
    }
}

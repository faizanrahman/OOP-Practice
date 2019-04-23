using System;

namespace OOP_Practice
{
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(string fn, string ln)
        {
            this.FirstName = fn;
            this.LastName = ln;
        }

        public virtual void PrintFullName()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName);
        }
    }

    class PartTimeEmployee : Employee
    {
        public float HourlyRate { get; set; }

        public PartTimeEmployee(string fn, string ln, float rate) : base(fn, ln)
        {
            //this.FirstName = fn;
            //this.LastName = ln;
            this.HourlyRate = rate;
        }

    }

    class FullTimeEmployee : Employee
    {
        public float Salary { get; set; }

        public FullTimeEmployee(string fn, string ln, float salary) : base("Fahad", "Rahman")
        {
            this.Salary = salary;
        }

        public override void PrintFullName()
        {
            Console.WriteLine(this.FirstName + " " + this.LastName + " makes a yearly salary of " + this.Salary);
        }
    }



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

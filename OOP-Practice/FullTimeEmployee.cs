using System;

namespace OOP_Practice
{
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
}

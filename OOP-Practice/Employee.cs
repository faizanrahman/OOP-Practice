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
}

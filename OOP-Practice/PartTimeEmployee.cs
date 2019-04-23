namespace OOP_Practice
{
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
}

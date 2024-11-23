namespace CSharpPart2.ExampleUnitTest
{
    public class Employee
    {
        public decimal Salary { get; private set; }
        public decimal Bonus { get; private set; }
        public Employee(decimal salary) //ctor
        {
            if (salary <= 0) throw new ArgumentException("Salary cannot be 0 or -ve");
            this.Salary = salary; 
            this.Bonus = this.Salary* .20m;
        }
        public decimal CalculateTotalPay() => Salary + Bonus;
        public decimal CalculateTotalPay(decimal salary, decimal bonus) => salary + bonus;
    }
}

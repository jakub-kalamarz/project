public class PermanentEmployee : Employee
{
    public decimal Salary { get; set; }

    public PermanentEmployee(string id, string firstName, string lastName, decimal salary)
        : base(id, firstName, lastName)
    {
        Salary = salary;
    }

    public override string ToString()
    {
        return base.ToString() + $", Salary: {Salary}";
    }
}

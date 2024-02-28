public class Contractor : Employee
{
    public decimal HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public Contractor(string id, string firstName, string lastName, decimal hourlyRate, int hoursWorked)
        : base(id, firstName, lastName)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override string ToString()
    {
        return base.ToString() + $", Hourly Rate: {HourlyRate}, Hours Worked: {HoursWorked}";
    }
}

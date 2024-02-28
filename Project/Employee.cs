public abstract class Employee
{
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    protected Employee(string id, string firstName, string lastName)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"ID: {Id}, First Name: {FirstName}, Last Name: {LastName}";
    }
}

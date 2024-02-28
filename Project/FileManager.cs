using System.Collections.Generic;
using System.IO;
using System.Linq;

public class FileManager
{
    private string filePath;

    public FileManager(string filePath)
    {
        this.filePath = filePath;
    }

    public List<Employee> LoadEmployees()
    {
        var lines = File.ReadAllLines(filePath);
        var employees = new List<Employee>();

        foreach (var line in lines)
        {
            var parts = line.Split(',');
            if (parts.Length == 4)
            {
                employees.Add(new PermanentEmployee(parts[0], parts[1], parts[2], decimal.Parse(parts[3])));
            }
            else if (parts.Length == 5)
            {
                employees.Add(new Contractor(parts[0], parts[1], parts[2], decimal.Parse(parts[3]), int.Parse(parts[4])));
            }
        }

        return employees;
    }

    public void SaveEmployees(List<Employee> employees)
    {
        var lines = employees.Select(e =>
        {
            if (e is PermanentEmployee pe)
                return $"{pe.Id},{pe.FirstName},{pe.LastName},{pe.Salary}";
            if (e is Contractor c)
                return $"{c.Id},{c.FirstName},{c.LastName},{c.HourlyRate},{c.HoursWorked}";
            return null;
        }).Where(line => line != null).ToArray();

        File.WriteAllLines(filePath, lines);
    }
}

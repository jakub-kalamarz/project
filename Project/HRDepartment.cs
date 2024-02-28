using System.Collections.Generic;
using System.Linq;

public class HRDepartment : IEmployeeManagement
{
    private List<Employee> employees = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
        employees.Add(employee);
    }

    public void RemoveEmployee(string id)
    {
        var employee = employees.FirstOrDefault(e => e.Id == id);
        if (employee != null)
        {
            employees.Remove(employee);
        }
    }

    public void UpdateEmployee(string id, Employee updatedEmployee)
    {
        var employee = employees.FirstOrDefault(e => e.Id == id);
        if (employee != null)
        {
            employees.Remove(employee);
            employees.Add(updatedEmployee);
        }
    }

    public Employee GetEmployee(string id)
    {
        return employees.FirstOrDefault(e => e.Id == id);
    }

    public List<Employee> GetAllEmployees()
    {
        return new List<Employee>(employees);
    }

    public void DisplayAllEmployees()
    {
        foreach (var employee in employees)
        {
            System.Console.WriteLine(employee.ToString());
        }
    }
}

public interface IEmployeeManagement
{
    void AddEmployee(Employee employee);
    void RemoveEmployee(string id);
    void UpdateEmployee(string id, Employee employee);
    Employee GetEmployee(string id);
    void DisplayAllEmployees();
    List<Employee> GetAllEmployees();
}

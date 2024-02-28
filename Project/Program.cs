class Program
{
    static HRDepartment hrDepartment = new HRDepartment();
    static FileManager fileManager = new FileManager("database.txt");

    static void Main(string[] args)
    {
        LoadExistingEmployees();

        bool running = true;
        while (running)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Display All Employees");
            Console.WriteLine("3. Exit");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddEmployeeManually();
                    break;
                case "2":
                    hrDepartment.DisplayAllEmployees();
                    break;
                case "3":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }

        SaveEmployees();
    }

    static void LoadExistingEmployees()
    {
        var employees = fileManager.LoadEmployees();
        foreach (var employee in employees)
        {
            hrDepartment.AddEmployee(employee);
        }
    }

    static void AddEmployeeManually()
    {
        Console.WriteLine("Enter Employee Type (Permanent/Contractor):");
        string type = Console.ReadLine().ToLower();

        Console.WriteLine("Enter ID:");
        string id = Console.ReadLine();

        Console.WriteLine("Enter First Name:");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter Last Name:");
        string lastName = Console.ReadLine();

        if (type == "permanent")
        {
            Console.WriteLine("Enter Salary:");
            decimal salary = decimal.Parse(Console.ReadLine());
            hrDepartment.AddEmployee(new PermanentEmployee(id, firstName, lastName, salary));
        }
        else if (type == "contractor")
        {
            Console.WriteLine("Enter Hourly Rate:");
            decimal hourlyRate = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Hours Worked:");
            int hoursWorked = int.Parse(Console.ReadLine());
            hrDepartment.AddEmployee(new Contractor(id, firstName, lastName, hourlyRate, hoursWorked));
        }
        else
        {
            Console.WriteLine("Invalid employee type.");
        }
    }

    static void SaveEmployees()
    {
        // Assuming `hrDepartment` has a method to get all employees as a list
        var employees = hrDepartment.GetAllEmployees(); // This method needs to be implemented
        fileManager.SaveEmployees(employees);
    }
}

namespace Employee;

internal static class Program
{
    static void Main(string[] args)
    {
        const string name = "John";
        const string lastName = "Doe";
        const int experience = 5;
        const EmployeeType employeeType = EmployeeType.Worker;
        Employee tester = new(name, lastName)
        {
            EmployeeType = employeeType,
            Experience = experience
        };
        Console.WriteLine(tester.ToString());
        Console.ReadKey(true);
    }
}

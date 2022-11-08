namespace Employee;

public sealed class Employee
{
    private readonly string _name;
    private readonly string _lastName;

    private int _experience;

    /// <summary>
    ///  Get or set employee experience
    /// </summary>
    internal int Experience
    {
        get { return _experience; }
        set { _experience = value; }
    }

    /// <summary>
    /// Constructor with parameters
    /// </summary>
    /// <param name="name">
    /// EmpSoft name
    /// </param>
    /// <param name="lastName">
    /// EmpSoft surname
    /// </param>
    public Employee(string name, string lastName) : this()
    {
        _name = name;
        _lastName = lastName;
    }

    /// <summary>
    ///  Default constructor
    /// </summary>
    public Employee()
    {
        Experience = 1;
        _name = "Default";
        _lastName = "Default";
    }

    private EmployeeType _employeeType;

    /// <summary>
    ///  Get or set employee type
    /// </summary>
    internal EmployeeType EmployeeType
    {
        get => _employeeType;
        set => _employeeType = value;
    }
    
    /// <summary>
    /// Calculates salary based on employee type
    /// </summary>
    /// <returns>
    /// Salary
    /// </returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    internal decimal CalculateSalary()
    {
        decimal salary = EmployeeType switch
        {
            EmployeeType.Developer => 1500,
            EmployeeType.ShopManager => 500,
            EmployeeType.Worker => 300,
            _ => throw new ArgumentOutOfRangeException()
        };

        return salary + Experience * 100;
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{_name} {_lastName} - {EmployeeType} - {Experience} years - {CalculateSalary()}$";
    }
}

public static class EmployeeExtensions
{
    /// <summary>
    ///  Get employee type
    /// </summary>
    /// <param name="employee">
    /// EmpSoft
    /// </param>
    /// <returns>
    /// EmpSoft type
    /// </returns>
    public static decimal GetSalary(this Employee employee)
    {
        return employee.CalculateSalary();
    }
}

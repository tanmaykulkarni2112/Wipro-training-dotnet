namespace EmployeeDomain;

public abstract class Employee
{
    #region Fields
    private string name;
    private double salary;
    #endregion

    #region Properties

    public int Age { get; set; } 

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Salary
    {
        get { return salary; }
        set { salary = value; }
    }
    #endregion

    #region Constructors
    protected Employee()
    {
        Name = "No-Name";
        Salary = 0.0;
    }

    protected Employee(string name, double salary)
    {
        Name = name;
        Salary = salary;
    }
    #endregion

    #region Methods
    public abstract bool IsIntern();
    #endregion
}

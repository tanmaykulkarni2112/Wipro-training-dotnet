using EmployeeDomain;

// See https://aka.ms/new-console-template for more information
Employee intern = new Intern(20, "John", 1000);
Console.WriteLine(intern.Name);
Console.WriteLine(intern.Salary);
Console.WriteLine(intern.Age);
Console.WriteLine(intern.IsIntern());
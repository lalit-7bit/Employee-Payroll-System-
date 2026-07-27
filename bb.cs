using System;

// Interface
interface IPayable
{
    double CalculateSalary();
}

// Base Class
class Employee
{
    public int Id;
    public string Name;

    public Employee(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public virtual void Display()
    {
        Console.WriteLine("Employee ID   : " + Id);
        Console.WriteLine("Employee Name : " + Name);
    }
}

// Full-Time Employee
class FullTimeEmployee : Employee, IPayable
{
    private double MonthlySalary;

    public FullTimeEmployee(int id, string name, double salary)
        : base(id, name)
    {
        MonthlySalary = salary;
    }

    public double CalculateSalary()
    {
        return MonthlySalary;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Employee Type : Full Time");
        Console.WriteLine("Salary        : $" + CalculateSalary());
    }
}

// Part-Time Employee
class PartTimeEmployee : Employee, IPayable
{
    private int HoursWorked;
    private double RatePerHour;

    public PartTimeEmployee(int id, string name, int hours, double rate)
        : base(id, name)
    {
        HoursWorked = hours;
        RatePerHour = rate;
    }

    public double CalculateSalary()
    {
        return HoursWorked * RatePerHour;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Employee Type : Part Time");
        Console.WriteLine("Salary        : $" + CalculateSalary());
    }
}

// Contract Employee
class ContractEmployee : Employee, IPayable
{
    private double ContractAmount;

    public ContractEmployee(int id, string name, double amount)
        : base(id, name)
    {
        ContractAmount = amount;
    }

    public double CalculateSalary()
    {
        return ContractAmount;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("Employee Type : Contract");
        Console.WriteLine("Salary        : $" + CalculateSalary());
    }
}

// Main Class
class Program
{
    static void Main(string[] args)
    {
        Employee[] employees =
        {
            new FullTimeEmployee(101, "Rahul", 50000),
            new PartTimeEmployee(102, "Priya", 80, 300),
            new ContractEmployee(103, "Amit", 45000)
        };

        Console.WriteLine("===== EMPLOYEE PAYROLL SYSTEM =====\n");

        foreach (Employee emp in employees)
        {
            emp.Display();
            Console.WriteLine("----------------------------------");
        }

        Console.ReadLine();
    }
}
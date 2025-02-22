namespace LinqDemo;
public class Employee
{

	public string Name { get; set; }
    public Department Department { get; set; }
    public double Salary { get; set; }

    public Employee(string name, Department department, double salary)
        => (Name, Department, Salary) = (name, department, salary);
}

public enum Department
{
    HR,
    ИТ,
    Продажи,
    Финансы,
    Маркетинг
}

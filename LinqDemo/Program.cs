using Dumpify;
using LinqDemo;

internal class Program
{
	private static void Main(string[] args)
	{
		List<Employee> employees = [
			new Employee ( "Джон", Department.HR, 50000 ) ,
			new Employee ( "Джон", Department.ИТ, 75000 ),
			new Employee ( "Джон",	 Department.Финансы, 65000 ),
			new Employee ( "Джон",	 Department.ИТ, 80000 ),
			new Employee ( "Джон",	 Department.HR, 45000 ),
			new Employee ( "Джон",	 Department.Маркетинг, 55000 ),
			new Employee ( "Джеймс", Department.Продажи, 70000 ),
			new Employee ( "Джеймс", Department.Финансы, 67000 ),
			new Employee ( "Джеймс", Department.ИТ, 82000 ),
			new Employee ( "Джеймс", Department.Маркетинг, 60000 )
		];

		var result = employees.DistinctBy(x => x.Name).Select(x => x.Name);
		result.Dump();

		//var result = employees.Index();

		//var result = employees.CountBy(x => x.Department);
		//var result = employees.MaxBy(x => x.Department);
		//var result = employees.MinBy(x => x.Department);

		//var result = employees.OrderByDescending(x => x.Salary).Skip(9).Take(1);
		//var result = employees.OrderByDescending(x => x.Salary).Take(3);

		//var result = employees.Count(x => x.Salary >= 75_000);
		//var result = employees.First(x => x.Name.StartsWith('P'));
		//var result = employees.OrderByDescending(x => x.Salary).First();
		//var result = employees.OrderByDescending(x => x.Salary).First();
		//var result = employees.OrderBy(x => x.Salary).Last();


		//var result = employees.Sum(x => x.Salary);
		//var result = employees.Min(x => x.Salary);
		//var result = employees.Max(x => x.Salary);
		//var result = employees.Average(x => x.Salary);

		//var result = employees.All(x => x.Salary >= 30_000);
		//var result = employees.Any(x => x.Salary < 20_000);
		//var result = employees.Any();

		//var result = employees.GroupBy(x => x.Department).ToDictionary(g => g.Key, g => g.Count())
		//    .Where(x => x.Value < 3);
		//var result = employees.GroupBy(x => x.Department).ToDictionary(g => g.Key);

		//var result = employees.Where(x => x.Name.StartsWith('P')).Select(x => x.Salary);
		//var result = employees.Where(x => x.Department == Department.HR);

		//var names = employees.Select(x => x.Name);

		//names.Dump();
	}
}


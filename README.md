<a id="anchor"></a>
# Как использовать LINQ в C#
<a href="#anchor" target="_blank"><img src="Cover 20250222_013a.jpg" alt="Image" width="300" /></a>
## Введение

> LINQ (Language Integrated Query) — это функция в C#, которая позволяет упростить работу с данными. Вместо того чтобы писать сложные SQL-запросы, можно использовать более простой и понятный синтаксис LINQ. Это помогает избежать ошибок и обеспечивает последовательный способ работы с данными из различных источников.

## Основные понятия

🙂 Ключевым понятием в LINQ является выражение «query». Это простой и понятный способ фильтрации, сортировки, группировки или преобразования данных. LINQ может быть записан двумя способами:</br>
Синтаксис запроса, похожий на синтаксис SQL.
Метод расширения в интерфейсе IEnumerable.

```csharp
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
```
+ 💻 [Пример использования LINQ](https://github.com/DeNaN20250203/How-To-Use-LINQ-in-CSharp/blob/main/LinqDemo/Program.cs)
```csharp
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
```
[PS: в данных примерах использована библиотека вывода на консоль для C#…](https://github.com/MoaidHathot/Dumpify) </br>
**Dumpify** - это библиотека C #, обычно используемая в приложениях для проверки качества кода. В Dumpify нет ошибок, в нем нет уязвимостей, у него разрешительная лицензия и низкий уровень поддержки. Вы можете загрузить его с GitHub.</br>
Повысьте производительность и отладочность, добавив методы расширения .Dump() в консольные приложения. Выгрузите любой объект структурированным и красочным способом в консоль, выполните трассировку, отладьте события или свой собственный пользовательский вывод. 
[Видео по **Dumpify**](https://vk.com/video614312645_456239062 "Видео по Dumpify")
	
<a href="https://github.com/DeNaN20250203" target="_blank"><img src="GitHubDeJra.png" alt="Image" width="300" /></a>
[Верх](#anchor)

<a id="anchor"></a>

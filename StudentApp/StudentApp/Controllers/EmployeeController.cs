using StudentApp.Controllers.Interface;
using StudentApp.Domen;
using StudentApp.Services;

namespace StudentApp.Controllers;

public class EmployeeController : IPersonController<Person>
{
    private readonly EmploeeService _empService = new EmploeeService();
    public void Create(string firstName, int age) => _empService.Create(firstName,age);
    public static void PaySalary<T>(T person) where T: Employee => Console.WriteLine($"{person.Name} выплачена зарплата 10000р. ");
}
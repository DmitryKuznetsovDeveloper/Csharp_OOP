using StudentApp.Domen;
using StudentApp.Services.Interfaces;

namespace StudentApp.Services;

public class EmploeeService : IPersonService<Employee>
{
    private int _count;
    public List<Employee> ListValue { get; }
    public EmploeeService() => ListValue = new List<Employee>();
    public void Create(string firstName, int age) => throw new NotImplementedException();
    }
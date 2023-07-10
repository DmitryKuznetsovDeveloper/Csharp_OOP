using StudentApp.Domen;

namespace StudentApp.Controllers.Interface;

public interface IPersonController<T> where T : Person
{
    public void Create(string firstName, int age);
}
using StudentApp.Domen;

namespace StudentApp.Services.Interfaces;

public interface IPersonService<T> 
{
    public List<T> ListValue { get; }
    public void Create(string firstName, int age); 
}
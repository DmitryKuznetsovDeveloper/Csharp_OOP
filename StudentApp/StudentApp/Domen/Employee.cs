namespace StudentApp.Domen;

public class Employee : Person
{
    public string Special { get; }
    public Employee(string firstName, int age, String special) : base(firstName,age) =>  Special = special;
}
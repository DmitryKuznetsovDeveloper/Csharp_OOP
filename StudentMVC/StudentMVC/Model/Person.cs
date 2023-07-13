namespace StudentMVC.Model;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person()
    {
        Name = "Неизвестно";
        Age = -1;
    }
    public Person(string name) : this() => Name = name;
    public Person(string name ,int age) : this(name)  => Age = age;
    public override string ToString() => $"\nName : {Name}\nAge : {Age}";
    
}
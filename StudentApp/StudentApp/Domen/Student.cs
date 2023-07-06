using System.Collections;
namespace StudentApp.Domen;

public class Student : Person, IComparable<Student>
{
    public int Id { get; }

    public Student(string name, int age, int id) : base(name, age) => Id = id;
    public override string ToString() => $"Student : {base.ToString()}\nId : {Id}\n";
    public int CompareTo(Student? other)
    {
        if ( Age == other?.Age)
        {
            if (Id == other.Id) return 0;
            if (Id > other.Id) return 1;
            if (Id < other.Id) return -1;
        }

        if (Age > other?.Age) return 1;
        else return -1;
    }
   
}
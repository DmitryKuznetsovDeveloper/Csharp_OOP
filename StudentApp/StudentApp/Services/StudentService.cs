using StudentApp.Domen;
using StudentApp.Services.Interfaces;

namespace StudentApp.Services;

public class StudentService : IPersonService<Student>
{
    private int _count;
    public List<Student> ListValue { get; }
    public StudentService() => ListValue = new List<Student>();

    public void Create(string firstName, int age) {
        Student per = new Student(firstName,age,_count);
        _count++;
        ListValue.Add(per);
    }

    public void SortStudentListByFIO() => ListValue.Sort(new PersonComparator<Student>().CompareToValue);
}
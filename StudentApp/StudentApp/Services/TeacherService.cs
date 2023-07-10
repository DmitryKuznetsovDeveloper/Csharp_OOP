using System.Threading.Channels;
using StudentApp.Domen;
using StudentApp.Services.Interfaces;

namespace StudentApp.Services;

public class TeacherService : IPersonService<Teacher>
{
    public List<Teacher> ListValue { get; }

    public TeacherService() => ListValue = new List<Teacher>();
    
    // метод для реализации интерфейса
    public void Create(string firstName, int age)
    {
        Teacher per = new Teacher(firstName, age);
        ListValue.Add(per);
    }
    // перегрузка метода с 3 параметрами 
    public void Create(string firstName, int age, string academicDegree)
    {
        Teacher per = new Teacher(firstName, age, academicDegree);
        ListValue.Add(per);
    }
    // метод сортировки 
    public void SortStudentListByFIO() => ListValue.Sort(new PersonComparator<Student>().CompareToValue);

    // метод вывода 
    public void ShowListTeacher(List<Teacher> list)
    {
        foreach (var varTeacher in list)
        {
            Console.WriteLine(varTeacher.ToString());
        }
    }
}
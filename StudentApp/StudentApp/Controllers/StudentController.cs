using StudentApp.Controllers.Interface;
using StudentApp.Domen;
using StudentApp.Services;

namespace StudentApp.Controllers;

public class StudentController : IPersonController<Student>
{
    private  readonly StudentService DATA_SERVICE = new StudentService();

    public void Create(string firstName, int age)
    {
        DATA_SERVICE.Create(firstName,age);
        DATA_SERVICE.SortStudentListByFIO();
    }
}
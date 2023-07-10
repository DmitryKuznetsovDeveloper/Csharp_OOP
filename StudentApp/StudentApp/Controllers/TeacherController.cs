using StudentApp.Controllers.Interface;
using StudentApp.Domen;
using StudentApp.Services;

namespace StudentApp.Controllers;

public class TeacherController : IPersonController<Teacher>
{
    private readonly TeacherService _teacherService = new TeacherService();
    public void Create(string firstName, int age) => _teacherService.Create(firstName,age);
    public void Create(string firstName, int age, string academicDegree) => _teacherService.Create(firstName,age,academicDegree);
}
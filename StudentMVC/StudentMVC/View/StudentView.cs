using StudentMVC.ConfigLabel;
using StudentMVC.Controller;
using StudentMVC.Model;

namespace StudentMVC.View;

public class StudentView : IGetView
{
    public void PrintAllStudents(Dictionary<long,Student> students)
    {
        foreach (var stud in students) 
            Console.WriteLine($"{stud.Key} - {stud.Value}");
    }
    public string Prompt(string message) 
    {
        Console.Write($"{message}");
        return Console.ReadLine() ?? string.Empty;
    }

    public Student ReadStudent() => throw new NotImplementedException();
    }
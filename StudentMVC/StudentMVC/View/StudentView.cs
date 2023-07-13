using StudentMVC.ConfigLabel;
using StudentMVC.Controller;
using StudentMVC.Model;

namespace StudentMVC.View;

public class StudentView : IGetView
{
    /// <summary>
    /// метод вывода студентов
    /// </summary>
    /// <param name="students"></param>
    public void PrintAllStudents(Dictionary<long,Student> students)
    {
        foreach (var stud in students) 
            Console.WriteLine($"{stud.Key} - {stud.Value}");
    }
    /// <summary>
    /// метод получения ввода от пользователя
    /// </summary>
    /// <param name="message">сообщение для пользователя</param>
    /// <returns></returns>
    public string Prompt(string message) 
    {
        Console.Write($"{message}");
        return Console.ReadLine() ?? string.Empty;
    }

    // заглушка
    public Student ReadStudent() => throw new NotImplementedException();
    }
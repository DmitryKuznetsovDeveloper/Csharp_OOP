using StudentMVC.Model;

namespace StudentMVC.Controller;

public interface IGetView
{
    // Метод выводит информацию о каждом студенте
    public void PrintAllStudents(Dictionary<long,Student> students);
    // Метод для запроса ввода пользователя, чтобы получить команду или данные от него
    public string Prompt(string msg);
    // Метод для чтения данных о студенте.
    public Student ReadStudent();
}
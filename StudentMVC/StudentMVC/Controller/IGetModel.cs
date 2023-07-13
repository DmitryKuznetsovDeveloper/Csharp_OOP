using StudentMVC.Model;

namespace StudentMVC.Controller;

public interface IGetModel
{
    // Коллекция студентов
    public Dictionary<long,Student> StudentsDictionary { get; set; }

    /// <summary>
    /// Поиск студентов по индексу
    /// </summary>
    /// <param name="studentSearch">индекс</param>
    /// <returns></returns>
    public List<Student> SearchStudent(long studentSearch);

    /// <summary>
    /// Поиск студентов по имени 
    /// </summary>
    /// <param name="studentSearch">имя студента</param>
    /// <returns></returns>
    public List<Student> SearchStudent(string studentSearch);

    /// <summary>
    /// Поиск студентов по возросту
    /// </summary>
    /// <param name="studentSearch">Возраст студентов</param>
    /// <returns></returns>
    public List<Student> SearchStudent(int studentSearch);

    /// <summary>
    /// Удаление студента по индексу
    /// </summary>
    public void DeleteStudent();
    
    /// <summary>
    /// Изменение записи студента 
    /// </summary>
    /// <param name="student">Измененный студент</param>
    public void UpdateStudent(Student student);
}
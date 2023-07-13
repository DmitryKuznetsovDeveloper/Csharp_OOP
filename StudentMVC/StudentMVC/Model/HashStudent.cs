using StudentMVC.Controller;

namespace StudentMVC.Model;

public class HashStudent : IGetModel
{
    // Коллекция студентов, свойство
    public Dictionary<long,Student> StudentsDictionary { get; set; }
    
    // Свойство для запоминания ID студента
    private long SearchIdStudent { get;  set;}

    /// <summary>
    /// Поиск студентов по индексу
    /// </summary>
    /// <param name="studentSearch">индекс</param>
    /// <returns></returns>
    public List<Student> SearchStudent(long studentSearch)
    {
        List<Student> studentsList = new List<Student>();
        foreach (var student in StudentsDictionary)
        {
            if (student.Key == studentSearch)
            {
                SearchIdStudent = student.Key;
                studentsList.Add(student.Value);
            }
        }
        return studentsList;
    }
    
    /// <summary>
    /// Поиск студентов по имени 
    /// </summary>
    /// <param name="studentSearch">имя студента</param>
    /// <returns></returns>
    public List<Student> SearchStudent(string studentSearch)
    {
        List<Student> studentsList = new List<Student>();
        foreach (var student in StudentsDictionary)
        {
            if (student.Value.Name.ToLower() == studentSearch.ToLower())
            {
                SearchIdStudent = student.Key;
                studentsList.Add(student.Value);
            }
        }
        return studentsList;
    }
    
    /// <summary>
    /// Поиск студентов по возросту
    /// </summary>
    /// <param name="studentSearch">Возраст студентов</param>
    /// <returns></returns>
    public List<Student> SearchStudent(int studentSearch)
    {
        List<Student> studentsList = new List<Student>();
        foreach (var student in StudentsDictionary)
        {
            if (student.Value.Age == studentSearch)
            {
                SearchIdStudent = student.Key;
                studentsList.Add(student.Value);
            }
        }
        return studentsList;
    }
    
    /// <summary>
    /// Удаление студента по индексу
    /// </summary>
    public void DeleteStudent() => StudentsDictionary.Remove(SearchIdStudent);
    
    /// <summary>
    /// Изменение записи студента 
    /// </summary>
    /// <param name="student">Измененный студент</param>
    public void UpdateStudent(Student student) => StudentsDictionary.TryAdd(SearchIdStudent, student);
}
using System.Collections;

namespace StudentApp.Domen;

public class StudentGroup :  IEnumerable, IEnumerator, IComparable<StudentGroup>
{
    // Свойства
    public List<Student> Group { get; }
    public int IdGroup { get; }
    
    // Конструктор
    public StudentGroup(List<Student> group, int idGroup)
    {
        Group = group;
        IdGroup = idGroup;
    }
    // Переопределение метода ToString
    public override string ToString() => $"\nStudentGroup : {IdGroup} - number of students {Group.Count}";
    
    //Реализация интерфейса IComparable<StudentGroup>
    public int CompareTo(StudentGroup? studentGroup)
    {
        if (Group.Count == studentGroup?.Group.Count) return 0;
        if (Group.Count > studentGroup?.Group.Count) return 1;
        if (Group.Count < studentGroup?.Group.Count) return -1;
        return -1;
    }

    //Реализация интерфейса IEnumerator
    // указатель текущей позиции элемента 
    private int _position = -1;
    
    // Передвинуть внутрений указатель (position) на одну позицию
    public bool MoveNext()
    {
        _position++;
        if (_position < Group.Count) return true;
        else
        {
            Reset();
            return false;
        }
    }
    // Обнуляем индекс позиции 
    public void Reset() => _position = -1;

    public Student Current
    {
        get
        {
            try
            {
                return Group[_position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
    object IEnumerator.Current => Current;
    
    // Реализация интерфейса IEnumerable
    IEnumerator IEnumerable.GetEnumerator() => this as IEnumerator;
}
using System.Collections;

namespace StudentApp.Domen;

public class StudentSteam :  IEnumerable, IEnumerator
{
    //Свойства 
    private int steamNumber;
    public List<StudentGroup> ListGroups { get; }

    public StudentSteam(List<StudentGroup> listGroups)
    {
        ListGroups = listGroups;
        steamNumber = ListGroups.Count;
    }

    public override string ToString() => $"\nSteamNumber :  {steamNumber}";

    // Реализация интерфейса IEnumerable
    IEnumerator IEnumerable.GetEnumerator() => this as IEnumerator;
    
    //Реализация интерфейса IEnumerator
    // указатель текущей позиции элемента 
    private int _position = -1;
    
    // Передвинуть внутрений указатель (position) на одну позицию
    public bool MoveNext()
    {
        _position++;
        if (_position < ListGroups.Count) return true;
        else
        {
            Reset();
            return false;
        }
    }

    // Обнуляем индекс позиции 
    public void Reset() => _position = -1;
    public StudentGroup Current
    {
        get
        {
            try
            {
                return ListGroups[_position];
            }
            catch (IndexOutOfRangeException)
            {
                throw new InvalidOperationException();
            }
        }
    }
    object IEnumerator.Current => Current;

    // Метод вывода в консоль
    public void ShowGroups(List<StudentGroup> studentSteam)
    {
        foreach (StudentGroup group in studentSteam)
        {
            Console.WriteLine(ToString());
            Console.WriteLine(group);
            foreach (Student student in group)
            {
                Console.WriteLine(student);
            }
        }
    }
}
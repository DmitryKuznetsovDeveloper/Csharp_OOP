namespace Solid;
//1) Переписать код в соответствии с Single Responsibility Principle:
public class Employee
{
    //Свойства доступные для чтения
    public string NameWorker { get; private set; }
    public DateTime DateOfEmployment { get; private set; }
    
    /// <summary>
    ///Конструктор 
    /// </summary>
    /// <param name="nameWorker">Имя работника</param>
    /// <param name="dateOfEmployment">день, месяц, год, трудоустройства</param>
    public Employee(string nameWorker, DateTime dateOfEmployment)
    {
        NameWorker = nameWorker;
        DateOfEmployment = dateOfEmployment;
    }
    //Переопределенный метод доступа, для информации о работнике
    public override string ToString() => $"Name employee: {NameWorker}\n" +
                                         $"Date Of Employment: Day: {DateOfEmployment.Day}, Month: {DateOfEmployment.Month}, Year: {DateOfEmployment.Year}\n";
}
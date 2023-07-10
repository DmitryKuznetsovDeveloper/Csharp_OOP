namespace StudentApp.Domen;

public class Teacher : Person
{
    // свойство
    public string AcademicDegree { get;}
    // 2 конструктора 
    public Teacher(string firstName, int age) : base(firstName, age) => AcademicDegree = "Неизвестно";
    public Teacher(string firstName, int age, string acadDegree) : base(firstName, age) => AcademicDegree = acadDegree;

    // переопределение метода 
    public override string ToString() => base.ToString() + $"\nAcademicDegree : {AcademicDegree}";

}
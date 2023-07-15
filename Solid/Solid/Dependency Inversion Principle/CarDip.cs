namespace Solid.Dependency_Inversion_Principle;

public class CarDip : Machine
{
    //Переопределенное свойство типа двигателя
    public override string TypeEngine { get; set; } = "PetrolEngine";
    
    //Используем базовый конструктор 
    public CarDip(string typeEngine) : base(typeEngine) {}
    
    //Тут определям вариант запуска двигателя.
    public override void Start() => throw new NotImplementedException();
}
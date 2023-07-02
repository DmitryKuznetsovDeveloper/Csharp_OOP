using Supermarket.Interface;

namespace Supermarket.Classes;

public class TaxService : IActorBehaviuor
{
    //Свойства
    public string Name { get; set; }
    public bool IsTakeOrder { get; set; }
    public bool IsMakeOrder { get; set; }
    //переопределенный метод вывода
    public override string ToString() => $"{Name}";
    //конструктор
    public TaxService()=> Name = "Tax audit";
    }
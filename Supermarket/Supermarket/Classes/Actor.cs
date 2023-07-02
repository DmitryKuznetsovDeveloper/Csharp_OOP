using Supermarket.Interface;

namespace Supermarket.Classes;

public abstract class Actor : IActorBehaviuor
{
    // абстрактные свойства
    public abstract string Name { get; set; }
    public abstract bool IsTakeOrder { get; set;}
    public abstract bool IsMakeOrder { get; set;}
    
    // реализованный конструктор
    public Actor(string name) => Name = name;
    // переопределен встроенный метод 
    public override string ToString() => $"{Name}";
    }

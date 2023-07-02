using Supermarket.Classes;
namespace Supermarket.Interface;

public interface IActorBehaviuor
{
    public string Name { get; set; }
    public bool IsTakeOrder { get; set; } 
    public bool IsMakeOrder { get; set; }
    
}
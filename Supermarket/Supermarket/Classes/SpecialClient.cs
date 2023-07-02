namespace Supermarket.Classes;

public class SpecialClient : Actor
{
    // Свойство
    public int IdVip { get; set; }
    //Унаследованные переопредленные свойства 
    public override string Name { get; set; }
    public override bool IsTakeOrder { get; set; }
    public override  bool IsMakeOrder { get; set; }
    // конструктор
    public SpecialClient(string name, int id) : base(name) => IdVip = id;
}
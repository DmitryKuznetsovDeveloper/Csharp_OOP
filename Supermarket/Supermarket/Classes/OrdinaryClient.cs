using Supermarket.Interface;

namespace Supermarket.Classes;

public class OrdinaryClient : Actor , IReturnOrder
{
    //Унаследованные переопредленные свойства 
    public override string Name { get; set; }
    public override bool IsTakeOrder { get; set; }
    public override bool IsMakeOrder { get; set; }
    
    // конструктор с перевызовом базового конструктора
    public OrdinaryClient(string name) : base(name){}
    
    // реализация интерфейса возврата с заглушками 
    public bool IsReturnApproved(string nameProduct, string reasoтnReturn) => throw new NotImplementedException();
    public void PurchaseReturns(int accountNumber, int costGoods) => throw new NotImplementedException();
}
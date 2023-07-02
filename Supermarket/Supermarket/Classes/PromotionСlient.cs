using Supermarket.Interface;

namespace Supermarket.Classes;

public class PromotionСlient : IActorBehaviuor, IReturnOrder, ITermsAction
{
    // приватное поле и свойства  статические
    private static int _maxNumberAction = 100;
    private static int MaxNumberAction { get => _maxNumberAction;}
    public static int ParticipatingCounter { get; set; }
    
    // Свойства
    public int CounterAction { get; set; }
    public string ShareName { get; set; }
    public long ClientId { get; set; }
    public string Name { get; set; }
    public bool IsTakeOrder { get; set; }
    public bool IsMakeOrder { get; set; }
    
    // конструктор
    public PromotionСlient()
    {
        CounterAction = ++ParticipatingCounter;
        Name = "Promotion Сlient";
        ShareName = "Name Promotion";
        ClientId = -1;
    }
    // переопределен встроенный метод 
    public override string ToString() => $"{ShareName}: акция рассщитана на {MaxNumberAction} человек," +
                                         $" вы {CounterAction} покупатель {Name}";
    
    //Реализация метода интерфейса условия акции, давать акцию покупателю или нет 
    public bool IssueShare(int maxNuberAction, int counterAction) => maxNuberAction < counterAction;
    // реализация интерфейса возврата с заглушками 
    public bool IsReturnApproved(string nameProduct, string reasoтnReturn) => throw new NotImplementedException();
    public void PurchaseReturns(int accountNumber, int costGoods) => throw new NotImplementedException();
    }
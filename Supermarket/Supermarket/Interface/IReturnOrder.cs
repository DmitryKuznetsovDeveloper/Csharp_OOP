namespace Supermarket.Interface;

public interface IReturnOrder
{
    // метод который одобряет или отказывает в возврате товара клиенту
    public bool IsReturnApproved(string nameProduct, string reasoтnReturn);
    
    //метод который делает возврат средст
    public void PurchaseReturns(int accountNumber, int costGoods);
}
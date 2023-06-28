namespace VendingMachine.Services;

public class CoinDispenser
{
    // Автосвойство, где неявно создается приватное поле nomonal;
    public int Nominal { get; set; }
    //Конструктор 
    public CoinDispenser(int nominal) => Nominal = nominal;
    // Переопределение метода ToString
    public override string ToString() => $"Номинал монеты : {Nominal}";
    // Методы
    public int GetSum(int insertCoin, int outCoin) => insertCoin + outCoin;
    public int GiveChange(int sumCoin, int price )
    {
        if (price < sumCoin) return sumCoin - price;
        return 0;
    }
    public bool Dispense(int price) => false;
}
namespace VendingMachine.Domen;
public class HotDrink : Product
{
    public int Temp { get; set; }
    //Конструкторы
    public HotDrink (int price, int place, String name, long id) : base(price, place, name, id) => Temp = 0;
    public HotDrink (int price, int place, String name, long id, int temp): base(price, place, name, id) => Temp = temp;
    // переопределение метода Tostring  с вызовом метода у базового класса
    public override string ToString()=> base.ToString() + $"Temperature = {Temp}";
}
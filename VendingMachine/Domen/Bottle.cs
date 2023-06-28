namespace VendingMachine.Domen;

public class Bottle : Product
{ 
    // Автосвойства
    public float BottleVolume { get; set;}
    
    //Конструкторы
    public Bottle(int price, int place, String name, long id) : base(price, place, name, id) => BottleVolume = 0f;
    public Bottle (int price, int place, String name, long id, float bottleVolume): base(price, place, name, id) => BottleVolume = bottleVolume;
    // переопределение метода Tostring  с вызовом метода у базового класса
    public override string ToString()=> base.ToString() + $"volume = {BottleVolume}";
}
namespace VendingMachine.Domen;
public class Product
{
    // Автосвойства 
    public int Price { get; set; }
    public int Place { get; set; }
    public string Name { get; set; }
    public long Id { get;}
    // Конструкторы
    public Product(){
        Price = -1;
        Place = -1;
        Name = "Неизвестно";
        Id = -1;
    }
    public Product(int price) : this() => Price = price;
    public Product(int price, int place) : this(price) => Place = place;
    public Product(int price, int place, String name) :this(price, place) => Name = name;
    public Product(int price, int place, String name, long id): this(price, place, name) => Id = id;
    // переопределение метода Tostring  с вызовом метода у базового класса
    public override string ToString()=>$"\nPrice = {Price}\nPlace = {Place}\nName = {Name}\nID = {Id}\n";
}

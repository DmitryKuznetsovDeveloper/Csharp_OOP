namespace VendingMachine.Domen;
public class Places
{
    // Автосвойство, где неявно создается приватное поле
    public int Place { get; set; }
    public bool Empty { get; set; }
    // Конструктор
    public Places(int place) => Place = place;
    // Методы
    public bool IsEmpty()=> Empty;
    public bool SetEmpty(bool empty) => Empty = empty;
}
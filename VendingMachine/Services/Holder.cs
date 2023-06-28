using System.Collections;
using VendingMachine.Domen;
namespace VendingMachine.Services;

public class Holder {
    // Поле
    private ArrayList places;
    // Думаю не стоит делать два цикла и двумерный массив, смысл ?
    // если мы и так знаем сколько там мест можно просто использовать 1;
    public Holder(int xSize)
    {
        places = new  ArrayList(xSize);
        for(int x = 0; x < xSize; x++) places.Add(new Places(x));
    }
    public bool Release(int index) => places.Contains(index);
    public int getBalance() =>  0;
}
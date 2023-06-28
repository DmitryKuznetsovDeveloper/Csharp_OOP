using VendingMachine.Domen;
namespace VendingMachine.Services;
public class VendingMachine {
    public Holder Holder { get; set; }
    public CoinDispenser Dispenser { get; set; }
    public List<Product> Assort { get; set; }
    public Display Display { get; set; }
    //Конструктор
    public VendingMachine(Holder holder, CoinDispenser dispenser, List<Product> assort, Display display)
    {
        Holder = holder;
        Dispenser = dispenser;
        Assort = assort;
        Display = display;
    }
    // Методы
    public void BuyProduct(Product p, int price) {
        if (Assort.Contains(p) && Holder.getBalance() >= price) {
            if (Dispenser.Dispense(price)) {
                ReleaseProduct(p, Holder);
                Display.Print("You have successfully bought " + p.Name + ".");
            } 
        } else {
            Display.Print("Product not available or insufficient balance.");
        }
    }
    public void ReleaseProduct(Product p, Holder h) {
        h.Release(0);
        Assort.Remove(p);
    }
    public void Cancel() => Dispenser.GiveChange(0, 0);
    }
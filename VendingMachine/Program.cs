using System.Collections;
using VendingMachine.Domen;
using VendingMachine.Services;

namespace VendingMachine
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            List<Product> assort = new List<Product>();
            Product item1 = new Product(100, 1, "Lays");
            Product item2 = new Product(50, 2, "Cola");
            Product item3 = new Bottle(150, 3, "Mineral Water", 101, (float)1.5);
            Product item4 = new HotDrink(400,4,"Coffe",45,36);
            Product item5 = new HotDrink(200,5,"Tea",23,46);
            assort.Add(item1);
            assort.Add(item2);
            assort.Add(item3);
            assort.Add(item4);
            assort.Add(item5);

            Holder hold1 = new Holder(10);
            CoinDispenser coinDesp = new CoinDispenser(0);
            Display disp = new Display();

            Services.VendingMachine venMachine = new Services.VendingMachine(hold1, coinDesp, assort, disp);
            foreach (var product in venMachine.Assort) Console.WriteLine(product.ToString());
        }
    }
}


using Supermarket.Classes;
using Supermarket.Interface;

namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // создаем экземпляр магащина
            Market magnit = new Market();
            // создаем экземпляры клиентов
            IActorBehaviuor client1 = new OrdinaryClient("Boris");
            IActorBehaviuor client2 = new SpecialClient("prezident",1001);
            IActorBehaviuor pensioner = new PensionerClient("Sergey Nikolay",1111);
            IActorBehaviuor tax = new TaxService();
            IActorBehaviuor promotionClient1 = new PromotionСlient();
            IActorBehaviuor promotionClient2 = new PromotionСlient();
            
            // клиенты пришли в магазин  
            magnit.AcceptToMarket(client1);
            magnit.AcceptToMarket(client2);
            magnit.AcceptToMarket(pensioner);
            magnit.AcceptToMarket(tax);
            magnit.AcceptToMarket(promotionClient1);
            magnit.AcceptToMarket(promotionClient2);
            
            // следим за действиями клиентов
            magnit.Update();
        }
    }
}


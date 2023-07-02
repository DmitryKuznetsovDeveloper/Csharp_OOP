using Supermarket.Interface;
namespace Supermarket.Classes;
public class Market : IMarketBehaviour, IQueueBehaviour
{
    // приватное поле список очереди 
    private List<IActorBehaviuor>_queue;
    
    // конструктор магазина 
    public Market() => _queue = new List<IActorBehaviuor>();
    
    // метод который показывает что клиент пришел в магазин и добавляет в очередь 
    public void AcceptToMarket(IActorBehaviuor actor) {
        Console.WriteLine($"{actor} клиент пришел в магазин ");
        TakeInQueue(actor);
    }
    
    // метод добавления в очередь 
    public void TakeInQueue(IActorBehaviuor actor) { 
        _queue.Add(actor);
        Console.WriteLine($"{actor} клиент добавлен в очередь");
    }
    
    // метод показывает что клиент ушел из магазина и удаляет его из списка 
    public void ReleaseFromMarket(List<IActorBehaviuor> actors) {
        foreach (var actor in actors)
        {
            Console.WriteLine($"{actor.Name} клиент ушел из магазина");
            _queue.Remove(actor);
        }
    }
    public void Update() {
        TakeOrder();
        GiveOrder();
        ReleaseFromQueue();
    }
    
    // метод показывает что клиент получил свой заказ
    public void GiveOrder() {
        foreach (var actor in _queue)
        {
            if (actor.IsMakeOrder)
            {
                actor.IsTakeOrder = true;
                Console.WriteLine($"{actor} клиент получил свой заказ ");
            }
        }
    }
    // метод показывает что клиент ушел из очереди
    public void ReleaseFromQueue() {
        List<IActorBehaviuor> releaseActors = new List<IActorBehaviuor>();
        foreach(var actor in _queue)
        {
            if(actor.IsTakeOrder)
            {
                releaseActors.Add(actor);
                Console.WriteLine($"{actor} клиент ушел из очереди ");
            }
        }
        ReleaseFromMarket(releaseActors);
    }
    
    // метод показывает что клиент сделал заказ
    public void TakeOrder() {
        foreach(var actor in _queue)
        {
            if (!actor.IsMakeOrder)
            {
                actor.IsMakeOrder = true;
                Console.WriteLine($"{actor} клиент сделал заказ ");
            }
        }
    }
}
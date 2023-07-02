namespace Supermarket.Interface;

public interface IQueueBehaviour
{
    //принять в очередь
    public void TakeInQueue(IActorBehaviuor actor);
    
    // убрать из очереди
    public void ReleaseFromQueue();
    
    //сделать заказ
    public void TakeOrder();
    // получить заказ
    public void GiveOrder();
}
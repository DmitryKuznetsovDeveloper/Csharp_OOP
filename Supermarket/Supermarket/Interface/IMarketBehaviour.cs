using Supermarket.Classes;
namespace Supermarket.Interface;

public interface IMarketBehaviour
{
    // добавить в магазин
    public void AcceptToMarket(IActorBehaviuor actor);
    // убрать из магазина
    public void ReleaseFromMarket(List<IActorBehaviuor> actor);
    // обновление действий клиентов
    public void Update();
}
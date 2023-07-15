namespace Solid.OpenClosedPrinciple;

public abstract class Vehicle
{
    // Черчеж транспорта 
    
    //Свойства 
    public virtual int MaxSpeed { get; set; }
    public virtual double SpeedLimit { get; set; }
    public virtual string TypeVehicle { get; set; }
    
    //Конструкторы
    protected Vehicle(int maxSpeed, string typeVehicle)
    {
        MaxSpeed = maxSpeed;
        TypeVehicle = typeVehicle;
    }
    protected Vehicle(int maxSpeed, double speedLimit, string typeVehicle): this(maxSpeed,typeVehicle) => SpeedLimit = speedLimit;
    
    // переопределенный метод для получения информации о экземлярах
    public override string ToString() => $"Type vehicle: {TypeVehicle}\n" +
                                         $"Max speed: {MaxSpeed}\n" +
                                         $"Speed limit: {SpeedLimit}\n";
}

namespace Solid.OpenClosedPrinciple;

public class Car : Vehicle
{
    public override double SpeedLimit { get; set; } = 0.8;
    public Car(int maxSpeed,string typeVehicle) : base(maxSpeed,typeVehicle){}
}
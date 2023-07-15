namespace Solid.OpenClosedPrinciple;

public class Bus : Vehicle
{
    public override double SpeedLimit { get; set; } = 0.6;

    public Bus(int maxSpeed,string typeVehicle) : base(maxSpeed,typeVehicle){}
}
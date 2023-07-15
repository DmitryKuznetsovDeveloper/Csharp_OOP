namespace Solid.OpenClosedPrinciple;

public static class SpeedCalculation
{
    /// <summary>
    ///Рассчитываем допустимую скорость в зависимости от транспорта
    /// </summary>
    /// <param name="vehicle">вид транспорта</param>
    /// <returns>допустимая скорость</returns>
    public static double CalculateAllowedSpeed(Vehicle vehicle) => vehicle.MaxSpeed * vehicle.SpeedLimit;
}
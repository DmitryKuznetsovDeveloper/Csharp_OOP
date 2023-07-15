namespace Solid.InterfaceSegregationPrinciple;

public class Circle : IShapeArea
{
    //Свойство 
    public double Radius { get; set; }
    
    //Конструктор
    public Circle(double radius)=> Radius = radius;
    
    //Реализация интерфейса IShapeArea
    /// <summary>
    /// Нахождение площади окружности
    /// </summary>
    /// <returns>площади окружности</returns>
    public double Area() => Math.PI * Math.Pow(Radius,2);

    }
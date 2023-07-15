namespace Solid.InterfaceSegregationPrinciple;

public class Cube : IShapeArea, IShapeVolume
{
    //Свойство
    public int Edge { get; set; }
    //Конструктор
    public Cube(int edge) => Edge = edge;
    
    //Реализация интерфейса IShapeArea
    /// <summary>
    /// Нахождение площади куба
    /// </summary>
    /// <returns></returns>
    public double Area() =>  6 * Math.Pow(Edge,2);
    
    //Реализация интерфейса IShapeVolume
    /// <summary>
    /// Нахождение объема куба
    /// </summary>
    /// <returns></returns>
    public double Volume() => Math.Pow(Edge,3);
    }
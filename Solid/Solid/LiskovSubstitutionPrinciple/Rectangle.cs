namespace Solid.LiskovSubstitutionPrinciple;

public class Rectangle 
{
    //Свойства
    public int Width { get; set; }
    public int Height { get; set; }

    //Конструктор
    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }
    /// <summary>
    /// Нахождение площади
    /// </summary>
    /// <returns></returns>
    public int Area() => Width * Height;
}
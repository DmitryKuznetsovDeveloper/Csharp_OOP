namespace Solid.LiskovSubstitutionPrinciple;

public class Square : Rectangle
{
    // Собственно это все =)) класс выполняет все то же самое что и родитель, плюс не ломает логику.
    public Square(int width, int height) : base(width, height){}
}
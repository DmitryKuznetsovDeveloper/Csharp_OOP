using System.Numerics;


namespace ComplexNumberCalculator;

internal class Program
{
    public static void Main(string[] args)
    {
        IViewCalculator viewCalculator = new ViewCalculator();
        IComplexCalculable complexCalculable = new ComplexCalculator();

        ControllerCalculator controllerCalculator = new ControllerCalculator(complexCalculable, viewCalculator);
        controllerCalculator.RunComplexCalculator();
    }
}


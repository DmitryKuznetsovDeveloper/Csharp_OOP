using System.Numerics;

namespace ComplexNumberCalculator;

public class ComplexCalculator : IComplexCalculable
{
    /// <summary>
    /// результат вычеслений
    /// </summary>
    public Complex Result { get; set; }
    
    public Complex Sum(Complex firstArg, Complex secondArg) => Result = Complex.Add(firstArg, secondArg);

    public Complex Multiply(Complex firstArg, Complex secondArg) => Result = Complex.Multiply(firstArg, secondArg);

    public Complex Division(Complex firstArg, Complex secondArg) => Result = Complex.Divide(firstArg, secondArg);
}
using System.Numerics;

namespace ComplexNumberCalculator;

public interface IComplexCalculable
{
   /// <summary>
   /// результат вычеслений
   /// </summary>
   public Complex Result { get; set; }
   /// <summary>
   /// Сложение комплексных чисел 
   /// </summary>
   /// <param name="firstArg"> первое комплексное чило</param>
   /// <param name="secondArg"> второе комплексное число </param>
   /// <returns>возвращает их сумму</returns>
   public  Complex Sum(Complex firstArg, Complex secondArg);
   
   /// <summary>
   /// Умножение комплексных чисел 
   /// </summary>
   /// <param name="firstArg">первое комплексное чило</param>
   /// <param name="secondArg">второе комплексное чило</param>
   /// <returns>возвращает результат перемножения</returns>
   public Complex Multiply(Complex firstArg, Complex secondArg);
   
   /// <summary>
   /// Деление комплексных чисел 
   /// </summary>
   /// <param name="firstArg">первое комплексное чило</param>
   /// <param name="secondArg">второе комплексное чило</param>
   /// <returns>возвращает результат деления</returns>
   public Complex Division(Complex firstArg, Complex secondArg);
   
}
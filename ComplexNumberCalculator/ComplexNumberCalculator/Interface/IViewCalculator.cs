using System.Numerics;

namespace ComplexNumberCalculator;

public interface IViewCalculator
{
    /// <summary>
    /// пункты меню
    /// </summary>
    public string Menu { get; }
    /// <summary>
    /// текст для суммы
    /// </summary>
    public string OperationSum { get;}
    /// <summary>
    /// текст для умножения
    /// </summary>
    public string OperationMultiply { get;}
    /// <summary>
    /// текст для деления
    /// </summary>
    public string OperationDivision { get; }
    /// <summary>
    /// получение двух комплестных чисел
    /// </summary>
    /// <param name="message">сообщение</param>
    /// <returns></returns>
    public Complex PromptComplex(string message);
    /// <summary>
    /// получение числа от пользователя
    /// </summary>
    /// <param name="message">сообщение</param>
    /// <returns></returns>
    public int PromptInt(string message);
}
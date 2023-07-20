using System.Numerics;

namespace ComplexNumberCalculator;

public class ViewCalculator : IViewCalculator
{
    public string Menu { get;} = "\nВыберите пункт меню\n" +
                                       "1 Сумировать комплекстные числа\n" +
                                       "2 Перемножить комплексные числа\n" +
                                       "3 Разделить комплексные числа\n"+
                                       "4 Выход\n\n";
    public string OperationSum { get;} = "Введите два комплексных числа которые хотите сумировать";
    public string OperationMultiply { get;} = "Введите два комплексных числа которые хотите перемножить";
    public string OperationDivision { get;} = "Введите два комплексных числа которые хотите разделить";

    public Complex PromptComplex(string message)
    {
        Console.Write(message);
        double first = Convert.ToDouble(Console.ReadLine());
        Console.Write(message);
        double second = Convert.ToDouble(Console.ReadLine());
        return new Complex(first,second);
    }
    
    public int PromptInt(string message)
    {
        Console.Write(message);
        try
        {
            Console.Write("-> ");
            return Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
            Logger.WriteLog("ошибка конвертации в выборе пункта меню");
            Console.WriteLine("Вы ввели не число =(");
            throw;
        }
    }
}
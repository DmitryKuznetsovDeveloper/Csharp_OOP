
namespace ComplexNumberCalculator;

public class ControllerCalculator
{
    //приватные поля из вьюхи и модели
    private IComplexCalculable _complexCalculable;
    private IViewCalculator _viewCalculator;
    //конструктор
    public ControllerCalculator(IComplexCalculable complexCalculable, IViewCalculator viewCalculator)
    {
        _complexCalculable = complexCalculable;
        _viewCalculator = viewCalculator;
    }

    /// <summary>
    /// метод для запуска программы
    /// </summary>
    public void RunComplexCalculator()
    {
        Logger.WriteLog("Вход в программу");
        bool isActive = true;

        while (isActive)
        {
            int menu = _viewCalculator.PromptInt($"{_viewCalculator.Menu}");
            switch (menu)
            {
                case 1:
                    Console.WriteLine(_viewCalculator.OperationSum);
                     _complexCalculable.Sum(_viewCalculator.PromptComplex("1: "),_viewCalculator.PromptComplex("2: "));
                    Console.WriteLine(_complexCalculable.Result);
                    Logger.WriteLog("Сложение двух комплексных чисел");
                    break;
                case 2:
                    Console.WriteLine(_viewCalculator.OperationMultiply);
                    _complexCalculable.Multiply(_viewCalculator.PromptComplex("1: "),_viewCalculator.PromptComplex("2: "));
                    Console.WriteLine(_complexCalculable.Result);
                    Logger.WriteLog("Умножение двух комплексных чисел");
                    break;
                case 3:
                    Console.WriteLine(_viewCalculator.OperationDivision);
                    _complexCalculable.Division(_viewCalculator.PromptComplex("1: "),_viewCalculator.PromptComplex("2: "));
                    Console.WriteLine(_complexCalculable.Result);
                    Logger.WriteLog("Деление двух комплексных чисел");
                    break;
                case 4:
                    isActive = false;
                    Logger.WriteLog("Выход из программы");
                    break;
            }
        }
    }
}
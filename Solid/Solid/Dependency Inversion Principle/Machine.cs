namespace Solid.Dependency_Inversion_Principle;

public abstract class Machine
{
    // Черчеж для машины, теперь можно будет сделать с любым двигателем и описать свой вариант запуска двигателя.
    //Свойство
    public abstract string TypeEngine { get; set; }
    //Конструктор
    protected Machine(string typeEngine) => TypeEngine = typeEngine;
    /// <summary>
    /// Метод запуска двигателя
    /// </summary>
    public abstract void Start();
}
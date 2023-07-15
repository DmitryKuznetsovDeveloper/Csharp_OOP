namespace Solid;
//1) Переписать код в соответствии с Single Responsibility Principle:
public class EmployeeSalary
{
    //Лист работников с установленной зарплатой
    public List<Employee> ListWorkers { get; private set; }
    
    //Базавоя ставка работника
    public int BaseSalary { get; private set; } = 100_000;
    
    //Процент налогового вычета
    public double TaxPercentage { get; private set; } = 0.13;

    /// <summary>
    /// Конструктор 
    /// </summary>
    /// <param name="listWorkers">Передать список сотрудников с базовой ставкой</param>
    public EmployeeSalary(List<Employee> listWorkers) => ListWorkers = listWorkers;
    
    /// <summary>
    /// Расчет зарплаты с вычетом налога
    /// </summary>
    /// <returns>Расчет зарплаты с вычетом налога</returns>
    public decimal CalculateNetSalary() {
        decimal tax = (decimal) (BaseSalary * TaxPercentage);
        return BaseSalary - tax;
    }

    //Переопределенный метод для вывода информации класса
    public override string ToString()=> $"Base Salary: {BaseSalary}\n" +
                                        $"Tax Percentage: {TaxPercentage}" ;
}
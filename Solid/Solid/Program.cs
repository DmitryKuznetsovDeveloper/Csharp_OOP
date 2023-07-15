using System.Threading.Channels;
using Solid.LiskovSubstitutionPrinciple;
using Solid.OpenClosedPrinciple;

namespace Solid
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //1) Переписать код в соответствии с Single Responsibility Principle:
            //Создаем работников
            Employee employee1 = new Employee("Ivan", DateTime.Now);
            Employee employee2 = new Employee("Petr", DateTime.Now);
            Employee employee3 = new Employee("Maria", DateTime.Now);

            //Создаем лист работников и заполняем его 
            List<Employee> listEmployees = new List<Employee>();
            listEmployees.Add(employee1);
            listEmployees.Add(employee2);
            listEmployees.Add(employee3);
            
            //Создаем класс для расчета зарплаты и добавляем туда  лист работников со стандартной ставкой.
            EmployeeSalary employeeSalary = new EmployeeSalary(listEmployees);
            
            //Узнаем какую нужно выплатить зарплату сотрудникам с вычетом налога
            Console.WriteLine($"Employees need to be paid: {employeeSalary.CalculateNetSalary()}");
            
            //2) Переписать код SpeedCalculation в соответствии с Open-Closed Principle:
            //Создаем экземпляры объектов различного траспорта
            Vehicle car = new Car(100, "Car");
            Vehicle bus = new Bus(100, "Bus");
            
            //Выводим рассчитаную допустимую скорость в зависимости от транспорта
            Console.WriteLine($"Maximum machine speed: {SpeedCalculation.CalculateAllowedSpeed(car)}");
            Console.WriteLine($"Maximum bus speed: {SpeedCalculation.CalculateAllowedSpeed(bus)}");

        }
    }
}


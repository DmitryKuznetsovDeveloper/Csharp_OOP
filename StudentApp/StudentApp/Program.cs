using StudentApp.Controllers;
using StudentApp.Domen;
using StudentApp.Services;

namespace StudentApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Создаем экземпляры учителей
            Teacher teacher1 = new Teacher("Иван", 35, "Кандидат наук");
            Teacher teacher2 = new Teacher("Игорь",43,"Доктор наук");
            Teacher teacher3 = new Teacher("Иван", 23, "Доцент");
            Teacher teacher4 = new Teacher("Игорь",56,"Профессор");

            //Создаем экземпляр сервиса и заполняем его 
            TeacherService teacherService = new TeacherService();
            teacherService.Create("Петрович",78,"Профессор");
            teacherService.ListValue.Add(teacher1);
            teacherService.ListValue.Add(teacher2);
            teacherService.ListValue.Add(teacher3);
            teacherService.ListValue.Add(teacher4);

            //Выводим список учителей
            teacherService.ShowListTeacher(teacherService.ListValue);
            //Сортируем
            teacherService.SortStudentListByFIO();
            Console.WriteLine(new string('=',50));
            //Выводим список учителей
            teacherService.ShowListTeacher(teacherService.ListValue);
            
            // Создание Сущностей студентов
            Student s1 = new Student("Иван", 25, 121);
            Student s2 = new Student("Игорь", 23, 301);
            Student s3 = new Student("Иван", 22, 121);
            Student s4 = new Student("Игорь",  23, 444);
            
            // Создаем сервис студентов и заполняем его
            StudentService studentService = new StudentService();
            studentService.ListValue.Add(s1);
            studentService.ListValue.Add(s2);
            studentService.ListValue.Add(s3);
            studentService.ListValue.Add(s4);
            
            
            // Создание Сущностей работников
            Employee e1 = new Employee("Иван", 25, "уборщик");
            Employee e2 = new Employee("Игорь", 23, "уборщик");
            Employee e3 = new Employee("Иван", 22, "уборщик");
            Employee e4 = new Employee("Игорь",  23, "уборщик");

            // Создаем сервис работников и заполняем его
            EmploeeService emploeeService = new EmploeeService();
            emploeeService.ListValue.Add(e1);
            emploeeService.ListValue.Add(e2);
            emploeeService.ListValue.Add(e3);
            emploeeService.ListValue.Add(e4);

            AverageAge<Teacher> averageAgeTeacher = new AverageAge<Teacher>();
            averageAgeTeacher.InfoAverageAge(teacherService.ListValue);
            Console.WriteLine($"У преподователей {averageAgeTeacher}");
            
            AverageAge<Student> averageAgeStudent = new AverageAge<Student>();
            averageAgeStudent.InfoAverageAge(studentService.ListValue);
            Console.WriteLine($"У студентов {averageAgeStudent}");
            
            AverageAge<Employee> averageAgeEmployee = new AverageAge<Employee>();
            averageAgeEmployee.InfoAverageAge(emploeeService.ListValue);
            Console.WriteLine($"У работников {averageAgeStudent}");
        }
    }
}
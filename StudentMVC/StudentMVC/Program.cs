using StudentMVC.ConfigLabel;
using StudentMVC.Controller;
using StudentMVC.Model;
using StudentMVC.View;

namespace StudentMVC
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //создаем словарь студентов
            Dictionary<long, Student> dictionaryStud = new Dictionary<long, Student>();
            //создвем студентов
            Student s1 = new Student("Сергей",  21, 101);
            Student s2 = new Student("Андрей",  22, 111);
            Student s3 = new Student("Иван", 22, 121);
            Student s4 = new Student("Игорь", 23, 301);
            Student s5 = new Student("Даша",  25, 171);
            Student s6 = new Student("Лена",  23, 104);
            // добавляем студентов в словарь 
            dictionaryStud.Add(1,s1);
            dictionaryStud.Add(2,s2);
            dictionaryStud.Add(3,s3);
            dictionaryStud.Add(4,s4);
            dictionaryStud.Add(5,s5);
            
            // Создаем объекты приведенные к интерфейсам для контроллера
            IGetModel model = new HashStudent();
            IGetView view = new StudentView();
            // делаем выбор языка
            ILabelMenu labelMenuConfig;
            ILabelStudent labelStudentConfig;
            Console.WriteLine("Введите цифру желаемого языка -\n" +
                          "1: Rus\n" +
                          "2: Eng");
            int lan = Convert.ToInt32(Console.ReadLine());
            if (lan == 1)
            {
                labelMenuConfig = new LabelMenuConfigRus();
                labelStudentConfig = new LabelStudentConfigRus(); 
            }
            else
            {
                labelMenuConfig = new LabelMenuConfigEng();
                labelStudentConfig = new LabelStudentConfigEng(); 
            }
            Console.Clear();
            model.StudentsDictionary = dictionaryStud;
            //создаем контроллер
            ControllerProgram control = new ControllerProgram(model, view, labelMenuConfig, labelStudentConfig );
            control.Run();
        }            
    }
}


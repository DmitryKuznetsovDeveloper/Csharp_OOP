using StudentApp.Domen;

namespace StudentApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Создание Сущностей студентов
            Student s1 = new Student("Иван", 25, 121);
            Student s2 = new Student("Игорь", 23, 301);
            Student s3 = new Student("Иван", 22, 121);
            Student s4 = new Student("Игорь",  23, 444);
            Student s5 = new Student("Даша",  23, 171);
            Student s6 = new Student("Лена",  23, 104);
            
            Student s7 = new Student("Андрей", 21, 168);
            Student s8 = new Student("Софья", 23, 201);
            Student s9 = new Student("Анна", 22, 121);
            Student s10 = new Student("Саша",  23, 544);
            Student s11 = new Student("Паша",  21, 181);

            // Создание Списков студентов
            List<Student> listStud = new List<Student>();
            listStud.Add(s1);
            listStud.Add(s2);
            listStud.Add(s3);
            listStud.Add(s4);
            listStud.Add(s5);
            listStud.Add(s6);
            
            List<Student> listStud2 = new List<Student>();
            listStud2.Add(s7);
            listStud2.Add(s8);
            listStud2.Add(s9);
            listStud2.Add(s10);
            listStud2.Add(s11);

            // Создание Групп со списком студентов
            StudentGroup group4580 = new StudentGroup(listStud, 4580);
            StudentGroup group4581 = new StudentGroup(listStud2, 4581);

            // Создание списка групп со списком студентов
            List<StudentGroup> listGroups = new List<StudentGroup>();
            listGroups.Add(group4580);
            listGroups.Add(group4581);
            
            StudentSteam studentSteam = new StudentSteam(listGroups);
            studentSteam.ShowGroups(studentSteam.ListGroups);
            studentSteam.ListGroups.Sort();
            Console.WriteLine(new string('=',50));
            studentSteam.ShowGroups(studentSteam.ListGroups);
            


        }
    }
}
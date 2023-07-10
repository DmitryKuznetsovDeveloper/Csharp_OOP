using StudentApp.Domen;

namespace StudentApp.Services;

public class AverageAge<T> where T: Person
{
    public long GetAverageAge { get; private set; }
    public void InfoAverageAge<T>(List<T> list) where T : Person
    {
        long result = 0;
        foreach (var item in list)
        {
            result += item.Age;
        }
        GetAverageAge =  result / list.Count();
    }

    public override string ToString() => $"средний возраст = {GetAverageAge}";
}
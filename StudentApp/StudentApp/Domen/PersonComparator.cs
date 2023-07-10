namespace StudentApp.Domen;

public class PersonComparator<T> :Person , IComparable<T> where T : Person
{
   public int CompareTo(T? other)
    {
        if (Age == other?.Age) return 0;
        if (Age > other?.Age) return 1;
        if (Age < other?.Age) return -1;
            return -1;
    }

   public int CompareToValue<T>(T personFirst, T personSecond) where T : Person
   {
       int result = personFirst.Name.CompareTo(personSecond.Name);
       if (result == 0)
       {
           if (personFirst.Age == personSecond.Age) return 0;
           if (personFirst.Age > personSecond.Age) return 1;
           return -1;
       } 
       return result; 
   }
}
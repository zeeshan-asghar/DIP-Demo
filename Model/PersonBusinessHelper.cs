using System;

namespace Model
{
    public class PersonBusinessHelper //For unit testing
    {
        public bool IsPersonEligibleToBuyFirearm(Person person)
        {
            int ageLimit = 18; //get from confiruation or DB

            return ((DateTime.Now.Year - person.DateOfBirth.Year) >= ageLimit);
        }
    }

    //public class PersonComparer : IComparable, IComparable<Person>
    //{
    //    public int CompareTo(object obj)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public int CompareTo(Person other)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public int Compare(object x, object y)
    //    {
    //        var lhs = x as Person;
    //        var rhs = y as Person;
    //        if (lhs == null || rhs == null) throw new InvalidOperationException();
    //        return Compare(lhs, rhs);
    //    }

    //    public int Compare(Person x, Person y)
    //    {
    //        int temp;
    //        return (temp = x.FirstName.CompareTo(y.FirstName)) != 0 ? temp : x.LastName.CompareTo(y.LastName);
    //    }

    //}
}
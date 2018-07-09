using System;

namespace Model
{
    public class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNo { get; set; }

        public string EmailAddress { get; set; }

        public DateTime DateOfBirth { get; set; }
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
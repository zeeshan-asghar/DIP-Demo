namespace Model
{
    public interface IPerson
    {
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNo { get; set; }
    }
}
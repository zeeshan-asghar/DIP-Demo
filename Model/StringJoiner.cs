namespace Model
{
    public class StringJoiner //For unit testing
    {
        public string Result = "";

        public void Join(string firstVal, string secondVal)
        {
            Result = ($"{firstVal} {secondVal}");
        }
    }
}
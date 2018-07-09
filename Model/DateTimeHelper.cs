using System;

namespace Model
{
    public class DateTimeHelper //For unit testing
    {
        public DateTime GetMLARateStartDate()
        {
            //reading from configuration or BRE

            return new DateTime(2016, 10, 3, 0, 0, 0);
        }
    }
}
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //https://www.youtube.com/watch?v=1sK6A8atorM
            //https://www.youtube.com/watch?v=NnZZMkwI6KI
            //https://www.youtube.com/watch?v=S4i2kptmTW0
            IPerson owner = Factory.CreatePerson();
            owner.FirstName = "Tim";
            owner.LastName = "Cornay";
            owner.EmailAddress = "ac@hotmail.com";
            owner.PhoneNo = "123-123-123";


            IChore chore = Factory.CreateChore();
            chore.ChoreName = "Take out the thrash";
            chore.Owner = owner;
            
            chore.PerformedWork(1);
            chore.PerformedWork(1.5);

            chore.CompleteChore();

            Console.WriteLine("Will be completed by Bilal Nawaz");

            Console.ReadLine();


            
        }
    }

   
}

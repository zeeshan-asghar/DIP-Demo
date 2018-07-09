using System;

namespace Model
{
    public class Emailer : IMessageSender
    {
        public void SendMessage(IPerson owner, string message)
        {
            Console.WriteLine($"sending email to {owner.EmailAddress}");
        }
    }
}
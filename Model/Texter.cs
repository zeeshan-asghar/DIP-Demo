using System;

namespace Model
{
    public class Texter : IMessageSender
    {
        public void SendMessage(IPerson owner, string message)
        {
            Console.WriteLine($"SMS is sending to {owner.FirstName} to say {message} at no {owner.PhoneNo}");
        }
    }
}
using System;

namespace OrderApp
{
    public class SMSService
    {
        public void SendSMS(Order order)
        {
            Console.WriteLine("SMS sent to customer");
        }
    }
}
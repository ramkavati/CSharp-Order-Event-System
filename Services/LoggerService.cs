using System;

namespace OrderApp
{
    public class LoggerService
    {
        public void LogOrder(Order order)
        {
            Console.WriteLine("Order logged successfully");
        }
    }
}
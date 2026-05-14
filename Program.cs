using System;

namespace OrderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create order processor
            OrderProcessor processor = new OrderProcessor();

            // Create services
            EmailService emailService = new EmailService();
            SMSService smsService = new SMSService();
            LoggerService loggerService = new LoggerService();

            // Subscribe services dynamically
            processor.OnOrderPlaced += emailService.SendEmail;
            processor.OnOrderPlaced += smsService.SendSMS;
            processor.OnOrderPlaced += loggerService.LogOrder;

            // Create order
            Order order = new Order
            {
                OrderId = 101,
                CustomerName = "Ramesh",
                Amount = 2500.50
            };

            // Process order
            processor.ProcessOrder(order);

            Console.WriteLine("\n--- Unsubscribing SMS Service ---\n");

            // Bonus: Unsubscribe SMS
            processor.OnOrderPlaced -= smsService.SendSMS;

            // Process another order
            Order order2 = new Order
            {
                OrderId = 102,
                CustomerName = "Kiran",
                Amount = 5400.75
            };

            processor.ProcessOrder(order2);

            Console.ReadLine();
        }
    }
}
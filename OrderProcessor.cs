using System;

namespace OrderApp
{
    // Delegate definition
    public delegate void OrderPlacedHandler(Order order);

    public class OrderProcessor
    {
        // Event declaration
        public event OrderPlacedHandler OnOrderPlaced;

        public void ProcessOrder(Order order)
        {
            Console.WriteLine($"Order Placed: {order.OrderId}");
            Console.WriteLine($"Customer Name: {order.CustomerName}");
            Console.WriteLine($"Amount: {order.Amount}");

            try
            {
                
                OnOrderPlaced?.Invoke(order);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while notifying services: " + ex.Message);
            }
        }
    }
}
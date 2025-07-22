using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var address1 = new Address("5th Ave Lake Road Grassy Park", "Cape Town", "Western Cape", "ZA");
        var address2 = new Address("6th Ave Sandpiper Retreat", "New York City", "New York", "USA");
        var address3 = new Address("3rd Ave Busy Corner Hout Bay", "Los Angeles", "California", "usa");

        var customer1 = new Customer("Martha Sims", address1);
        var customer2 = new Customer("Jerry Charlton", address2);
        var customer3 = new Customer("Lisa Smith", address3);

        var product1 = new Product("Cleanser", "CL234", 34.98, 3);
        var product2 = new Product("Moisturizer", "MZ654", 22.03, 1);
        var product3 = new Product("Sunscreen", "SN655", 19.77, 4);

        var order1 = new Order(customer1);
        var order2 = new Order(customer2);
        var order3 = new Order(customer3);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        order2.AddProduct(product3);
        order2.AddProduct(product1);

        order3.AddProduct(product1);
        order3.AddProduct(product2);

        Console.WriteLine("Order1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Order Total: {order1.CalculateTotalCost():0.00}\n");

        Console.WriteLine("Order2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Order Total: {order2.CalculateTotalCost():0.00}\n");

        Console.WriteLine("Order3:");    
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine($"Order Total: {order3.CalculateTotalCost():0.00}");
    }
}
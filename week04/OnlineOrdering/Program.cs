using System;

class Program
{
    static void Main(string[] args)
    {
        Address usaAddress = new Address("123 Main St", "Springfield", "IL", "USA");
        Address nonUsaAddress = new Address("456 Oak Ave", "Toronto", "ON", "Canada");

        Customer usaCustomer = new Customer("John Doe", usaAddress);
        Customer internationalCustomer = new Customer("Jane Smith", nonUsaAddress);

        Product product1 = new Product("Laptop", 101, 999.99, 1);
        Product product2 = new Product("Mouse", 102, 19.99, 2);
        Product product3 = new Product("Keyboard", 103, 49.99, 1);

        Order order1 = new Order(usaCustomer);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(internationalCustomer);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1:");
        Console.WriteLine($"Packing Label: {order1.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label: {order1.GetShippingLabel()}");
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice()}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine($"Packing Label: {order2.GetPackingLabel()}");
        Console.WriteLine($"Shipping Label: {order2.GetShippingLabel()}");
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice()}");
    }
}
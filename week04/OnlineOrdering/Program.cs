using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Ordering System");
        Console.WriteLine("======================");
        Console.WriteLine();

        // Create addresses
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Address address2 = new Address("456 Oak Ave", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Pine Rd", "Los Angeles", "CA", "USA");

        // Create customers
        Customer customer1 = new Customer("John Smith", address1);
        Customer customer2 = new Customer("Maria Garcia", address2);
        Customer customer3 = new Customer("David Johnson", address3);

        // Create products
        Product product1 = new Product("Laptop", "LAP1001", 899.99, 1);
        Product product2 = new Product("Wireless Mouse", "MOU2001", 29.99, 2);
        Product product3 = new Product("USB-C Cable", "CAB3001", 19.99, 3);
        Product product4 = new Product("Monitor", "MON4001", 249.99, 1);
        Product product5 = new Product("Keyboard", "KEY5001", 79.99, 1);
        Product product6 = new Product("Webcam", "WEB6001", 49.99, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);
        order2.AddProduct(product2);

        Order order3 = new Order(customer3);
        order3.AddProduct(product1);
        order3.AddProduct(product4);
        order3.AddProduct(product6);

        // Display order details
        Console.WriteLine("ORDER 1:");
        Console.WriteLine("--------");
        order1.DisplayOrderDetails();

        Console.WriteLine("ORDER 2:");
        Console.WriteLine("--------");
        order2.DisplayOrderDetails();

        Console.WriteLine("ORDER 3:");
        Console.WriteLine("--------");
        order3.DisplayOrderDetails();
    }
}
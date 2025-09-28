using System;
using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalProductCost = 0;
        foreach (Product product in _products)
        {
            totalProductCost += product.CalculateProductCost();
        }

        double shippingCost = _customer.IsInUSA() ? 5 : 35;
        return totalProductCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "PACKING LABEL:\n";
        packingLabel += "================\n";
        foreach (Product product in _products)
        {
            packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = "SHIPPING LABEL:\n";
        shippingLabel += "================\n";
        shippingLabel += $"{_customer.GetName()}\n";
        shippingLabel += $"{_customer.GetAddress().GetFullAddress()}\n";
        return shippingLabel;
    }

    public void DisplayOrderDetails()
    {
        Console.WriteLine(GetShippingLabel());
        Console.WriteLine(GetPackingLabel());
        
        Console.WriteLine("ORDER DETAILS:");
        Console.WriteLine("==============");
        foreach (Product product in _products)
        {
            Console.WriteLine($"  {product.GetProductInfo()} = ${product.CalculateProductCost():F2}");
        }
        
        double shippingCost = _customer.IsInUSA() ? 5 : 35;
        Console.WriteLine($"Shipping Cost: ${shippingCost:F2}");
        Console.WriteLine($"Total Cost: ${CalculateTotalCost():F2}");
        Console.WriteLine();
    }
}
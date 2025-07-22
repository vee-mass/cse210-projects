using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

public class Order
{
    private List<Product> products;

    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;

        foreach (Product product in products)
        {
            totalCost += product.GetTotalCost();
        }

        if (customer.LivesInUSA())
        {
            totalCost += 5;
        }

        else
        {
            totalCost += 35;
        }

        return totalCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Lable: \n";
        foreach (Product product in products)
        {
            label += $"{product.Name} (ID: {product.ProductID})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{customer.Name} \n{customer.Address.GetFullAddress()}";
    }
}
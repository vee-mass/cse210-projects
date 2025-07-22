using System;
using System.Dynamic;

public class Product
{
    private string name;
    private string productID;
    private double pricePerUnit;
    private int quantity;

    public Product(string name, string productID, double pricePerUnit, int quantity)
    {
        this.name = name;
        this.productID = productID;
        this.pricePerUnit = pricePerUnit;
        this.quantity = quantity;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string ProductID
    {
        get { return productID; }
        set { productID = value; }
    }

    public double PricePerUnit
    {
        get { return pricePerUnit; }
        set { pricePerUnit = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public double GetTotalCost()
    {
        return pricePerUnit * quantity;
    }

    
}
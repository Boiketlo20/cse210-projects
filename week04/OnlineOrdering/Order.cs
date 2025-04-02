using System;

public class Order{

    private List<Product> _product = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _product.Add(product);
    }

    public double GetTotalPrice()
    {
        double productsTotal = 0;
        foreach (Product product in _product)
        {
            productsTotal += product.GetTotalCost();
        }
    
        double shippingCost;
        if (_customer.livesInUSA()) 
        {
            shippingCost = 5;
        }
        else 
        {
            shippingCost = 35;
        }
    
        return productsTotal + shippingCost;
    }

    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n{_customer.GetAddress().GetFormattedAddress()}";
    }
    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in _product)
        {
            label += $"{product.GetName()} (ID: {product.GetId()})\n";
        }
        return label;
    }
}
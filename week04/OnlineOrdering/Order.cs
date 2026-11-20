public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _products = new List<Product>();
        _customer = customer;
    }

    public void AddOrders(Product product)
    {
        _products.Add(product);
    }

    public double TotalPrice()
    {
        double total = 0;
        
        foreach (Product product in _products)
        {
            total += product.CostPrice();
        }
        if (_customer.IsInUSA())  // This means if true
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    public void DisplayPrice(double totalPrice)
    {
        Console.WriteLine("---------------------------");
        Console.WriteLine($"Total price: ${totalPrice}");
    }

    public string ProductLabel()
    {
        Console.WriteLine("Product label:");
        string label = "";
        foreach (Product product in _products)
        {
            label += $".             {product.GetName()} - {product.GetId()}\n";
        }
        return label;
    }

    public void DisplayLabel(string label)
    {
        Console.WriteLine(label);
    }

    public string ShippingLabel()
    {
        return $"               Name: {_customer.GetName()}\n               {_customer.GetAddress()}";
    }

    public void DisplayShippingLabel(string shippingLabel)
    {
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(shippingLabel);
        Console.WriteLine("---------------------------");
    }

}
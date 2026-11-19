public class Product
{
    private string _productName;
    private string _id;
    private double _price;
    private int _quantity;

    public Product(string productName, string id, double price, int quantity)
    {
        _productName = productName;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    public string GetName()
    {
       return _productName;
    }

    public string GetId()
    {
      return _id;
    }
    public double CostPrice()
    {
        double cost = _price * _quantity;
        return cost;
    }
}
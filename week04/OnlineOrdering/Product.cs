public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public double CalculateProductCost()
    {
        return _price * _quantity;
    }

    public string GetProductInfo()
    {
        return $"{_name} (ID: {_productId}) - ${_price:F2} x {_quantity}";
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }
}
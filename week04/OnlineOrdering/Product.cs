public class Product
{
    // V A R I A B L E S
    private string _name;
    private int _productId;
    private float _price;
    private int _quantity;

    // C O N S T R U C T O R S
    public Product(string name, int id, float price, int quantity)
    {
        _name = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    // M E T H O D S

    // G E T T E R S
    public float GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetPackingInfo()
    {
        return $"Product: {_name}, ID: {_productId}";
    }
}
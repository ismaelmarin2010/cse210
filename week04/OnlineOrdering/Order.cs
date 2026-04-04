public class Order
{
    // V A R I A B L E S
    private List<Product> _products;
    private Customer _customer;


    // C O N S T R U C T O R S 
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }


    // M E T H O D S
    public void AddProduct(string name, int id, float price, int quantity)
    {
        Product newProduct = new Product(name, id, price, quantity);
        _products.Add(newProduct);
    }

    public void DisplayOrder()
    {
        Console.WriteLine($"----- Order for {_customer.GetCustomerName()} -----");
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(GetShippingLabel());
        Console.WriteLine("");
        Console.WriteLine("Packing Label:");
        foreach (string item in GetPacking())
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("");
        Console.WriteLine($"Total Price: ${GetTotalPrice():F2}");
        Console.WriteLine("");
    }


    // G E T T E R S
    public float GetTotalPrice()
    {
        float total = 0;
        for (int i = 0; i < _products.Count; i++)
        {
            total += _products[i].GetTotalCost();
        }
        int shippingCost = 0;
        if (_customer.GetIsUsa())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return total + shippingCost;
    }

    public List<string> GetPacking()
    {
        List<string> packing = new List<string>();
        for (int i = 0; i < _products.Count; i++)
        {
            packing.Add(_products[i].GetPackingInfo());
        }
        return packing;
    }

    public string GetShippingLabel()
    {
        return _customer.GetCustomer();
    }
}
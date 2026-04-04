public class Customer
{
    // V A R I A B L E S
    private string _name;
    private Address _address;

    // C O N S T R U C T O R S
    public Customer(string name, string street, string city, string state, string country)
    {
        _name = name;
        _address = new Address(street, city, state, country);
    }

    // M E T H O D S

    // G E T T E R S
    public bool GetIsUsa()
    {
        return _address.IsUsa();
    }

    public string GetCustomerName()
    {
        return _name;
    }
    
    public string GetCustomer()
    {
        return $"{_name}\n{_address.GetAddress()}";
    }
    
}
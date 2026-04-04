public class Address
{
    // V A R I A B L E S
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // C O N S T R U C T O R S 
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // M E T H O D S
    public bool IsUsa()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}
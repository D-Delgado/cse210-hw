public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public Address(string street, string city, string state, string zipcode, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool IsInUsa()
    {
        bool inUsa = false;
        if (_country == "USA")
        {
            inUsa = true;
        }
        return inUsa;
    }
    public string StringAddress()
    {
        string addressString = $"{_street}\n{_city}, {_state}, {_country}";
        return addressString;
    }

}
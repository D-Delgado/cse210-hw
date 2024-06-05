public class Customer
{
    private Address _address;
    private string _name;
    public Customer(string name, string street, string city, string state, string zipcode, string country)
    {
        _name = name;
         
        _address = new Address(street, city, state, zipcode, country);
    }
    public bool IsInUsa()
    {
        bool isInUsa = false;
        if (_address.IsInUsa() == true)
        {
            isInUsa = true;
        }
        return isInUsa;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.StringAddress();
    }
}
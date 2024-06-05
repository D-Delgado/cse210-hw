using System;
using System.Collections.Generic;

class Address
{
    public string Street { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string Zip {get; private set; }
    public string Country { get; private set; }

    public Address(string street, string city, string state, string zip, string country)
    {
        Street = street;
        City = city;
        State = state;
        Zip = zip;
        Country = country;
    }

    public override string ToString()
    {
        return $"{Street}\n{City}, {State}\n{Country}";
    }
}
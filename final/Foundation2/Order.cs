public class Order
{
    private List<Product> _products;
    private Customer _customer;
    public Order()
    {
        _products = new List<Product>();
    }
    public void AddProduct(string name, string id, double price, int quantity)
    {
        Product p = new Product(name, id, price, quantity);
        _products.Add(p);
    }
    public double GetTotalCost()
    {
        List<double> totalPrices = new List<double>();
        foreach (Product product in _products)
        {
            totalPrices.Add(product.GetTotalCost());
        }
        double shippingFee = 5;
        if (_customer.IsInUsa() == false)
        {
            shippingFee = 35;
        }
        double totalCost = totalPrices.Sum() + shippingFee;
        return totalCost;
    }
    public void SetCustomer(string name, string street, string city, string state, string zipcode, string country)
    {
        Customer c = new Customer(name, street, city, state, zipcode, country);
        _customer = c;
    }
    public void DisplayPackingLabel()
    {
        Console.WriteLine("Packing Label");
        Console.WriteLine("***********************");
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetId()} - {product.GetName()}");
        }
        Console.WriteLine();
    }
    public void DisplayShippingLabel()
    {
        Console.WriteLine("Shipping Label");
        Console.WriteLine("***********************");
        Console.WriteLine($"{_customer.GetName()}\n{_customer.GetAddress()}");
        Console.WriteLine();
    }
}
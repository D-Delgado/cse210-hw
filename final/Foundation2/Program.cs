using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        order1.AddProduct("Apples", "AAA1", 2, 5);
        order1.AddProduct("Oranges", "OOO1", 3, 4);
        order1.SetCustomer("Michael Jordon", "1901 W Madison St", "Chicago", "IL", "60612", "USA");

        Order order2 = new Order();
        order2.AddProduct("Apples", "AAA1", 2, 6);
        order2.AddProduct("Oranges", "OOO1", 3, 5);
        order2.AddProduct("Starwberries", "SSS1", 5, 4);
        order2.SetCustomer("John Stockton", "301 S Temple", "Salt Lake City", "UT", "84101",  "UK");

        Console.WriteLine($"Order1 Total Cost: ${order1.GetTotalCost()}");
        order1.DisplayPackingLabel();
        order1.DisplayShippingLabel();
        Console.WriteLine();

        Console.WriteLine($"Order2 Total Cost: ${order2.GetTotalCost()}");
        order2.DisplayPackingLabel();
        order2.DisplayShippingLabel();
        Console.WriteLine();

    }
}
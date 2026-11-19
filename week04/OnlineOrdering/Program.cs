using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------------ONLINE OEDERS---------------");
        // Order 1 (USA Address - tests domestic shipping logic if applicable)
        Order order2 = new Order(new Customer("Sarah Jenkins", new Address("742 Evergreen Terrace", "Springfield", "IL", "USA")));
        order2.AddOrders(new Product("Wireless Mouse", "P101", 25, 1));
        order2.AddOrders(new Product("Mechanical Keyboard", "P102", 80, 1));
        order2.AddOrders(new Product("USB-C Cable", "P103", 12, 2));
        order2.AddOrders(new Product("Mousepad", "P104", 15, 1));
        order2.DisplayPrice(order2.TotalPrice());
        order2.DisplayLabel(order2.ProductLabel());
        order2.DisplayShippingLabel(order2.ShippingLabel());

        // Order 2 (Nigeria Address)
        Order order3 = new Order(new Customer("Chinedu Okafor", new Address("14 Admiralty Way", "Lekki", "Lagos", "Nigeria")));
        order3.AddOrders(new Product("Rice (5kg)", "P201", 15, 2));
        order3.AddOrders(new Product("Vegetable Oil", "P202", 8, 3));
        order3.AddOrders(new Product("Tomato Paste", "P203", 3, 6));
        order3.AddOrders(new Product("Seasoning Cubes", "P204", 2, 4));
        order3.DisplayPrice(order3.TotalPrice());
        order3.DisplayLabel(order3.ProductLabel());
        order3.DisplayShippingLabel(order3.ShippingLabel());

        // Order 3 (UK Address)
        Order order4 = new Order(new Customer("David Miller", new Address("221B Baker Street", "London", "Greater London", "UK")));
        order4.AddOrders(new Product("Coffee Beans", "P301", 18, 2));
        order4.AddOrders(new Product("Ceramic Mug", "P302", 10, 4));
        order4.AddOrders(new Product("French Press", "P303", 35, 1));
        order4.AddOrders(new Product("Oat Milk", "P304", 4, 3));
        order4.DisplayPrice(order4.TotalPrice());
        order4.DisplayLabel(order4.ProductLabel());
        order4.DisplayShippingLabel(order4.ShippingLabel());

    }
}
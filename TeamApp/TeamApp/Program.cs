using TeamApp.Models;
using TeamApp;

class Program
{
    static void Main()
    {
        var manager = new ProductManager("products.json");

        Console.Write("Enter product name: ");
        string name = Console.ReadLine();

        Console.Write("Enter price product: ");
        decimal price = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Enter quantity products: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        var product = new Product
        {
            Name = name,
            Price = price,
            Quantity = quantity
        };

        manager.SaveProduct(product);

        Console.WriteLine("List products:");

        var products = manager.LoadProducts();
        foreach (var p in products)
        {
            Console.WriteLine($"• {p.Name} | price: {p.Price} | quantity: {p.Quantity}");
        }
    }
}


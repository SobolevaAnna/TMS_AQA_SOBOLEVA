namespace AbstractClasses.Game;

public class Set : Base
{
    public List<Product> SetProducts { get; set; }

    public Set(string name, double price, List<Product> setProducts) : base(name, price)
    {
        SetProducts = setProducts;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"\nСостав комплекта:");
        foreach (var product in SetProducts)
        {
            product.PrintInfo();
        }
    }

    public override bool IsExpired()
        {
            foreach (var product in SetProducts)
                if (product.IsExpired())
                    return true;
            return false;
        }
}

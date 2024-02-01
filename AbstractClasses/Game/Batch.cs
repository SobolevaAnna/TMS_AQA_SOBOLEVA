namespace AbstractClasses.Game;
public class Batch : Product
{
    public int Amount;

    public Batch(string name, int amount, double price, DateOnly productionDate, DateOnly expirationDate) : base(name, price, productionDate, expirationDate)
    {
        Amount = amount;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Партия продукта: {Name}. Количество товара в партии: {Amount} шт. Стоимость товара в партии: {Price}. Дата изготовления: {ProductionDate}. Годен до: {ExpirationDate}");
    }
    public override bool IsExpired()
    {
        return DateOnly.FromDateTime(DateTime.Now) > ExpirationDate;
    }   
}
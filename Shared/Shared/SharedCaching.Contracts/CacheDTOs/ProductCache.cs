namespace SharedCaching.Contracts.CacheDTOs;

public class ProductCacheEvent
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public override string ToString()
    {
        return Id.ToString();
    }
}

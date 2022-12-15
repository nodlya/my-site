using System.Text.Json.Serialization;

namespace BlazorApp1.Shared;

public class Product
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Name { get; init; }

    public bool IsBought { get; set; } = false;

    public Product(ProductForm form)
    {
        Name = form.ProductName ?? throw new ArgumentException("NAME NOT CAN BE NULL UGA BUGA");
    }

    [JsonConstructor]
    public Product(Guid id, string Name, bool isBought)
    {
        this.Id = id;
        this.Name = Name;
        this.IsBought = isBought;
    }

    
    public Product()
    {
        
    }


}

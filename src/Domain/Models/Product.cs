namespace Domain.Models;

public class Product
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string? Description { get; set; }
    public string? Category { get; set; }
    public DateTime DateCreated { get; set; }
    public DateTime LastUpdated { get; set; }
}
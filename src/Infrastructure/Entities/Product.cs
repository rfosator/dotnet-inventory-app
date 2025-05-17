using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities;

[Table("products")]
public class Product
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key, Column("id")]
    public int Id { get; set; }
    [Column("name")]
    public string Name { get; set; } = null!;
    [Column("description")]
    public string? Description { get; set; }
    [Column("price")]
    public double Price { get; set; }
    [Column("created_at")]
    public DateTime CreatedAt { get; set; } = DateTime.Now.ToUniversalTime();
    [Column("last_updated")]
    public DateTime LastUpdated { get; set; }
    [Column("category_id")]
    public int? CategoryId { get; set; }
    
    [Column("category")]
    public virtual Category? Category { get; set; }
}
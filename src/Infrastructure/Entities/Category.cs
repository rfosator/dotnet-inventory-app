using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Entities;

[Table("categories")]
public class Category
{
    [Key, Column("id")]
    public int Id { get; set; }
    [Column("name")]
    public string Name { get; set; } = null!;

    public virtual List<Product>? Products { get; set; }
}

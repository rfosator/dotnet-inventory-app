using System.Threading.Tasks;
using Infrastructure.Data;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Pages.Catalog
{
    public class CatalogItemModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public double Price { get; set; }
        public string? Description { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? LastUpdated { get; set; }
    }

    public class IndexModel : PageModel
    {
        public IEnumerable<CatalogItemModel> Catalog = [];

        [BindProperty]
        public List<Product> Products { get; set; } = default!;

        public async Task OnGet([FromServices] InventoryContext db)
        {
            Products = await db.Products.ToListAsync();
        }
    }
}
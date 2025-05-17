using System.Threading.Tasks;
using Infrastructure.Data;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Catalog
{
    public class AddModel(InventoryContext context) : PageModel
    {
        private readonly InventoryContext context = context;

        [BindProperty]
        public Product Product { get; set; } = default!;

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await context.Products.AddAsync(Product);
            await context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

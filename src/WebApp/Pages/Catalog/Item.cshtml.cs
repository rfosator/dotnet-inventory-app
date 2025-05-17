using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Catalog
{
    public class ItemModel : PageModel
    {
        public string? Id { get; set; }
        public void OnGet(string id)
        {
            Id = id;
        }
    }
}

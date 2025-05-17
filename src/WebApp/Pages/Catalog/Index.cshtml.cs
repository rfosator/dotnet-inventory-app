using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApp.Pages.Catalog
{
    public class CatalogItemModel
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int Stock { get; set; }
    }

    public class IndexModel : PageModel
    {
        public IEnumerable<CatalogItemModel> Strings = [];

        public void OnGet()
        {
            List<CatalogItemModel> list = [];
            for (int i = 0; i < 10; i++)
            {
                list.Add(new CatalogItemModel
                {
                    Id = Guid.NewGuid().ToString(),
                    Stock = Random.Shared.Next(60)
                });
            }
            Strings = list;
        }
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TechStoreInventory.Data;
using TechStoreInventory.Models;

namespace TechStoreInventory.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly InventoryContext _context;

        public IndexModel(InventoryContext context)
        {
            _context = context;
        }

        public IList<TechStoreInventory.Models.Products> Products { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Products = await _context.Products.AsNoTracking().ToListAsync();
        }
    }
}

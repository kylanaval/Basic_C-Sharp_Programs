using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TechStoreInventory.Data;
using TechStoreInventory.Models;

namespace TechStoreInventory.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly InventoryContext _context;

        public DetailsModel(InventoryContext context)
        {
            _context = context;
        }

        public TechStoreInventory.Models.Products Products { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null) return NotFound();

            Products = await _context.Products.FirstOrDefaultAsync(m => m.Id == id.Value);

            if (Products == null) return NotFound();
            return Page();
        }
    }
}

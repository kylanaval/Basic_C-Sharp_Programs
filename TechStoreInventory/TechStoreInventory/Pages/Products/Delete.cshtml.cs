using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TechStoreInventory.Data;
using TechStoreInventory.Models;

namespace TechStoreInventory.Pages.Products
{
    public class DeleteModel : PageModel
    {
        private readonly InventoryContext _context;

        public DeleteModel(InventoryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TechStoreInventory.Models.Products Products { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null) return NotFound();

            Products = await _context.Products.FindAsync(id.Value);

            if (Products == null) return NotFound();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (Products == null) return NotFound();

            var product = await _context.Products.FindAsync(Products.Id);
            if (product != null)
            {
                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("Index");
        }
    }
}

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TechStoreInventory.Data;
using TechStoreInventory.Models;

namespace TechStoreInventory.Pages.Products
{
    public class EditModel : PageModel
    {
        private readonly InventoryContext _context;

        public EditModel(InventoryContext context)
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
            if (!ModelState.IsValid)
            {
                return Page();
            }

            try
            {
                _context.Attach(Products).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductsExists(Products.Id))
                    return NotFound();
                else
                    throw;
            }

            return RedirectToPage("Index");
        }

        private bool ProductsExists(Guid id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}

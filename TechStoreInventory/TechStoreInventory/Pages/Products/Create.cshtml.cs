using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TechStoreInventory.Data;
using TechStoreInventory.Models;

namespace TechStoreInventory.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly InventoryContext _context;

        public CreateModel(InventoryContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TechStoreInventory.Models.Products Products { get; set; } = default!;

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

            Products.Id = Guid.NewGuid();
            _context.Products.Add(Products);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}

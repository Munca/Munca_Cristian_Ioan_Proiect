using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Munca_Cristian_Ioan_Proiect.Data;
using Munca_Cristian_Ioan_Proiect.Models;

namespace Munca_Cristian_Ioan_Proiect.Pages.Books
{
    public class DeleteModel : PageModel
    {
        private readonly Munca_Cristian_Ioan_Proiect.Data.Munca_Cristian_Ioan_ProiectContext _context;

        public DeleteModel(Munca_Cristian_Ioan_Proiect.Data.Munca_Cristian_Ioan_ProiectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FindAsync(id);

            if (Book != null)
            {
                _context.Book.Remove(Book);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

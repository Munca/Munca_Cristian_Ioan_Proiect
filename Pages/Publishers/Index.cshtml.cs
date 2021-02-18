using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Munca_Cristian_Ioan_Proiect.Data;
using Munca_Cristian_Ioan_Proiect.Models;

namespace Munca_Cristian_Ioan_Proiect.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Munca_Cristian_Ioan_Proiect.Data.Munca_Cristian_Ioan_ProiectContext _context;

        public IndexModel(Munca_Cristian_Ioan_Proiect.Data.Munca_Cristian_Ioan_ProiectContext context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}

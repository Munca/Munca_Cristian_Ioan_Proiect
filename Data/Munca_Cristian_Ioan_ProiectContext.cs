using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Munca_Cristian_Ioan_Proiect.Models;

namespace Munca_Cristian_Ioan_Proiect.Data
{
    public class Munca_Cristian_Ioan_ProiectContext : DbContext
    {
        public Munca_Cristian_Ioan_ProiectContext (DbContextOptions<Munca_Cristian_Ioan_ProiectContext> options)
            : base(options)
        {
        }

        public DbSet<Munca_Cristian_Ioan_Proiect.Models.Book> Book { get; set; }

        public DbSet<Munca_Cristian_Ioan_Proiect.Models.Publisher> Publisher { get; set; }

        public DbSet<Munca_Cristian_Ioan_Proiect.Models.Category> Category { get; set; }
    }
}

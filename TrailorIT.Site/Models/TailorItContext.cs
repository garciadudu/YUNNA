using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrailorIT.Site.Models
{
    public class TailorItContext: DbContext
    {
        public TailorItContext(DbContextOptions<TailorItContext> options) : base(options)
        { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Sexo> Sexos { get; set; }

    }
}

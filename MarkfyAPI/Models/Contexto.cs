using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Markfy.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Loja> Loja { get; set; }
        public DbSet<Produto> Produto { get; set; }
    }
}

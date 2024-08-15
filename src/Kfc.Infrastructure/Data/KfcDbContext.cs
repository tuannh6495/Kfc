using Kfc.Application.Enities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kfc.Infrastructure.Data
{
    public class KfcDbContext : DbContext
    {
        public KfcDbContext(DbContextOptions<KfcDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DAT;Database=EFCore-KfcDbContext;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
        public DbSet<MenuType> MenuTypes { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Combo> Combos { get; set; }
        public DbSet<ComboItem> ComboItems { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using MyShop.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Infrastructure.Data
{
    public sealed class CatalogContext : DbContext
    {
        public CatalogContext(DbContextOptions<CatalogContext> options) :base(options)
        {

        }

        public DbSet<CatalogItem> CatalogItems { get; set; }
        public DbSet<CatalogBrand> CatalogBrands { get; set; }
        public DbSet<CatalogType> CatalogTypes { get; set; }
    }
}

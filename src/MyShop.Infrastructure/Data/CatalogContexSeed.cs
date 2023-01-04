using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyShop.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Infrastructure.Data
{
    public class CatalogContexSeed
    {
        public static async Task SeedAsync(CatalogContext catalogContext, ILogger logger, int retry = 0)
        {
            var retryForAvailability = retry;

            try
            {
                if(!await catalogContext.CatalogBrands.AnyAsync())
                {
                    await catalogContext.AddRangeAsync(GetPreConfigureBrands);
                    await catalogContext.SaveChangesAsync();
                }
                if(!await catalogContext.CatalogItems.AnyAsync())
            }
            catch (Exception)
            {

                throw;
            }
        }



        private static IEnumerable<CatalogBrand> GetPreConfigureBrands()
        {
            return new List<CatalogBrand>
            {
                new("Azure"),
                new(".NET"),
                new("Visual Studio"),
                new("SQL Server"),
                new("Other")
            };
        }
    }
}
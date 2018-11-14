using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MegaDeskWeb.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MegaDeskWebContext(
                serviceProvider.GetRequiredService<DbContextOptions<MegaDeskWebContext>>()))
            {
                // Look for any movies.
                if (context.Quote.Any())
                {
                    return;   // DB has been seeded
                }
                context.SaveChanges();
            }
        }
    }
}



using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalatasarayShop.Data.Contexts
{
    public class GalatasarayShopContextFactory : IDesignTimeDbContextFactory<GalatasarayShopContext>
    {
        public GalatasarayShopContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GalatasarayShopContext>(); optionsBuilder.UseSqlServer("server=LAPTOP-PQI1145Q; database=GalatasarayShop; Trusted_Connection=true");
            return new GalatasarayShopContext(optionsBuilder.Options);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RecapProject1.Entities;

namespace RecapProject1
{
    public class NorthwindContext : DbContext
    {
        //Database set ediyoruz, Product diye bir Entity framework var ve bu veritabaninda Products adiyla tabloya sahiptir.
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}

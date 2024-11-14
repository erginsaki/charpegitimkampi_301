using egitimkampi301_entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EgitimKampi301_dataaccesslayer.Context
{
    public class ProjectContext:DbContext
    {

        public DbSet<Category> Categories { get; set; } // veri tabanına categories adında tablo yansıyacak.
                                                        // Pluralize : veri tabanına ait isim çoğul yapılır.Yalın hali class coğul hali tablo.
        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Customer> Customers { get; set; } 

        public DbSet<Admin> Admins { get; set; }


    }
}

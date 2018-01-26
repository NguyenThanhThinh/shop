using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shop.Data
{

    using shop.Models.EntityModels;
    using System.Data.Entity;

    public class ShopDbcontext : IdentityDbContext<User>
    {
        public ShopDbcontext() : base("shopdbcontext", throwIfV1Schema: false)
        {

        }
        public DbSet<About> Abouts { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categorys { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<SildeImage> SildeImages { get; set; }


        public static ShopDbcontext Create()
        {
            return new ShopDbcontext();
        }
    }

}

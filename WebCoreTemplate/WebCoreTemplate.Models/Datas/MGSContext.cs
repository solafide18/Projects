using Microsoft.EntityFrameworkCore;
using WebCoreTemplate.Models.Databases.MGS;

namespace WebCoreTemplate.Models.Datas
{
    public class MGSContext : DbContext
    {
        public MGSContext() { }
        public MGSContext(DbContextOptions<MGSContext> options) : base(options) { }

        public DbSet<barang> barang { get; set; }
        public DbSet<leveluser> leveluser { get; set; }
        public DbSet<order_trans> order_trans { get; set; }
        public DbSet<order_trans_detail> order_trans_detail { get; set; }
        public DbSet<petty_cash> petty_cash { get; set; }
        public DbSet<stock_on_hand> stock_on_hand { get; set; }
        public DbSet<tipe_trans> tipe_trans { get; set; }
        public DbSet<user_login> user_login { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<OrderDetails>().HasKey(k => new { k.OrderID, k.ProductID });
            //modelBuilder.Entity<RunningNumber>().HasKey(k => new { k.Year, k.RunningMonth });
        }
    }
}

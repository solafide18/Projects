using Microsoft.EntityFrameworkCore;
using WebCoreTemplate.Models.Databases.TestCandidate;

namespace WebCoreTemplate.Models.Datas
{
    public class TestCandidateContext : DbContext
    {
        public TestCandidateContext() { }
        public TestCandidateContext(DbContextOptions<TestCandidateContext> options) : base(options) { }
        public DbSet<Customers> customers { get; set; }
        public DbSet<OrderDetails> orderDetails { get; set; }
        public DbSet<Orders> orders { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<RunningNumber> runningNumber { get; set; }
        public DbSet<Categories> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrderDetails>().HasKey(k => new { k.OrderID, k.ProductID });
            modelBuilder.Entity<RunningNumber>().HasKey(k => new { k.Year, k.RunningMonth });
        }
    }
}

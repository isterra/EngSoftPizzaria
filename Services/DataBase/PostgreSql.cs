using Microsoft.EntityFrameworkCore;
using Models.DataBaseModels;

namespace Services.DataBase
{
    public class PostgreSql : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }


        public PostgreSql(DbContextOptions<PostgreSql> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OrderItems>()
      .HasOne<Order>()
      .WithMany()
      .HasForeignKey(oi => oi.OrderId)
      .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

using Akla.SharedData.Models;
using Microsoft.EntityFrameworkCore;

namespace Akla.SharedData.Context
{
    public class AklaDbContext : DbContext
    {
        #region Models DbSets
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<CustomerPhone> CustomerPhones { get; set; }
        public virtual DbSet<Delivery> Deliveries { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<DriverPhone> DriverPhones { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<MenuCategory> MenuCategories { get; set; }
        public virtual DbSet<MenuCategoryItem> MenuCategoryItems { get; set; }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<MenuItemPromotion> MenuItemPromotions { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }
        public virtual DbSet<Promotion> Promotions { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<RestaurantTable> RestaurantTables { get; set; }
        public virtual DbSet<Review> Reviews { get; set; } 
        #endregion

        public AklaDbContext(DbContextOptions<AklaDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Relationships
            modelBuilder.Entity<Address>()
                    .HasOne(a => a.Customer)
                    .WithMany(c => c.Addresses)
                    .HasForeignKey(a => a.CustomerId)
                    .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CustomerPhone>()
                .HasOne(cp => cp.Customer)
                .WithMany(c => c.PhoneNumbers)
                .HasForeignKey(cp => cp.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.RestaurantTable)
                .WithMany(c => c.Reservations)
                .HasForeignKey(r => r.RestaurantTableId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Reservation>()
                 .HasOne(r => r.Customer)
                 .WithMany(c => c.Reservations)
                 .HasForeignKey(r => r.CustomerId)
                 .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Customer)
                .WithOne(c => c.Review)
                .HasForeignKey<Review>(r => r.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.MenuItem)
                .WithMany(m => m.Reviews)
                .HasForeignKey(r => r.MenuItemId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Image>()
                .HasOne(i => i.MenuItem)
                .WithMany(m => m.Images)
                .HasForeignKey(i => i.MenuItemId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Image>()
                .HasOne(i => i.Promotion)
                .WithMany(p => p.Images)
                .HasForeignKey(i => i.PromotionId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<MenuItemPromotion>()
                .HasOne(mip => mip.Promotion)
                .WithMany(p => p.MenuItemPromotions)
                .HasForeignKey(mip => mip.PromotionId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<MenuItemPromotion>()
                .HasOne(mip => mip.MenuItem)
                .WithMany(m => m.MenuItemPromotions)
                .HasForeignKey(mip => mip.MenuItemId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<MenuCategoryItem>()
                .HasOne(mci => mci.MenuItem)
                .WithMany(m => m.MenuCategoryItems)
                .HasForeignKey(mci => mci.MenuItemId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<MenuCategoryItem>()
                .HasOne(mci => mci.MenuCategory)
                .WithMany(mc => mc.MenuCategoryItems)
                .HasForeignKey(mci => mci.MenuCategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.MenuItem)
                .WithMany(m => m.OrderItems)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.PaymentMethod)
                .WithMany(pm => pm.Orders)
                .HasForeignKey(o => o.PaymentMethodId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Delivery>()
                .HasOne(d => d.Order)
                .WithOne(o => o.Delivery)
                .HasForeignKey<Delivery>(d => d.OrderId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Delivery>()
                .HasOne(d => d.Driver)
                .WithMany(dr => dr.Deliveries)
                .HasForeignKey(d => d.DriverId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<DriverPhone>()
                .HasOne(dph => dph.Driver)
                .WithMany(d => d.PhoneNumbers)
                .HasForeignKey(dph => dph.DriverId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Driver>()
                .HasIndex(d => d.LicensePlate)
                .IsUnique();

            modelBuilder.Entity<Driver>()
                .HasIndex(d => d.PrimaryPhoneNumber)
                .IsUnique();
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}

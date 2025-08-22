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
                    .HasForeignKey(a => a.Customer_Id)
                    .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<CustomerPhone>()
                .HasOne(cp => cp.Customer)
                .WithMany(c => c.PhoneNumbers)
                .HasForeignKey(cp => cp.Customer_Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.RestaurantTable)
                .WithMany(c => c.Reservations)
                .HasForeignKey(r => r.RestaurantTable_Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Reservation>()
                 .HasOne(r => r.Customer)
                 .WithMany(c => c.Reservations)
                 .HasForeignKey(r => r.Customer_Id)
                 .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.Customer)
                .WithOne(c => c.Review)
                .HasForeignKey<Review>(r => r.Customer_Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Review>()
                .HasOne(r => r.MenuItem)
                .WithMany(m => m.Reviews)
                .HasForeignKey(r => r.MenuItem_Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Image>()
                .HasOne(i => i.MenuItem)
                .WithMany(m => m.Images)
                .HasForeignKey(i => i.MenuItem_Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Image>()
                .HasOne(i => i.Promotion)
                .WithMany(p => p.Images)
                .HasForeignKey(i => i.Promotion_Id)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<MenuItemPromotion>()
                .HasOne(mip => mip.Promotion)
                .WithMany(p => p.MenuItemPromotions)
                .HasForeignKey(mip => mip.Promotion_Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<MenuItemPromotion>()
                .HasOne(mip => mip.MenuItem)
                .WithMany(m => m.MenuItemPromotions)
                .HasForeignKey(mip => mip.MenuItem_Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<MenuCategoryItem>()
                .HasOne(mci => mci.MenuItem)
                .WithMany(m => m.MenuCategoryItems)
                .HasForeignKey(mci => mci.MenuItem_Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<MenuCategoryItem>()
                .HasOne(mci => mci.MenuCategory)
                .WithMany(mc => mc.MenuCategoryItems)
                .HasForeignKey(mci => mci.MenuCategory_Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.Order_Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.MenuItem)
                .WithMany(m => m.OrderItems)
                .HasForeignKey(oi => oi.Order_Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.PaymentMethod)
                .WithMany(pm => pm.Orders)
                .HasForeignKey(o => o.PaymentMethod_Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Delivery>()
                .HasOne(d => d.Order)
                .WithOne(o => o.Delivery)
                .HasForeignKey<Delivery>(d => d.Order_Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Delivery>()
                .HasOne(d => d.Driver)
                .WithMany(dr => dr.Deliveries)
                .HasForeignKey(d => d.Driver_Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.Customer_Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<DriverPhone>()
                .HasOne(dph => dph.Driver)
                .WithMany(d => d.PhoneNumbers)
                .HasForeignKey(dph => dph.Driver_Id)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Driver>()
                .HasIndex(d => d.License_Plate)
                .IsUnique();

            modelBuilder.Entity<Driver>()
                .HasIndex(d => d.PrimaryPhoneNumber)
                .IsUnique();
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}

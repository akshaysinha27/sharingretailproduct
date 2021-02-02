using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAPI.Models
{
    public partial class ProductRetailManagementDBContext : DbContext
    {
        //public ProductRetailManagementDBContext()
        //{
        //}

        public ProductRetailManagementDBContext(DbContextOptions<ProductRetailManagementDBContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<Carts> Carts { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<VendorStocks> VendorStocks { get; set; }
        public virtual DbSet<Vendors> Vendors { get; set; }
        public virtual DbSet<WishLists> WishLists { get; set; }
        public virtual DbSet<Carts> Carts { get; set; }


        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer("Data Source=PCIN474826;Initial Catalog=ProductRetailManagementDB;Integrated Security=True");
        //            }
        //        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Carts>(entity =>
        //    {
        //        entity.HasKey(e => e.CartId);

        //        entity.Property(e => e.DeliveryDate).HasColumnType("datetime");
        //    });

        //    modelBuilder.Entity<Customers>(entity =>
        //    {
        //        entity.HasKey(e => e.CustomerId);

        //        entity.Property(e => e.Address).HasMaxLength(1000);

        //        entity.Property(e => e.Email).HasMaxLength(500);

        //        entity.Property(e => e.FirstName).HasMaxLength(500);

        //        entity.Property(e => e.LastName).HasMaxLength(500);

        //        entity.Property(e => e.Password).HasMaxLength(50);
        //    });

        //    modelBuilder.Entity<Products>(entity =>
        //    {
        //        entity.HasKey(e => e.ProductId);

        //        entity.Property(e => e.Description).HasMaxLength(4000);

        //        entity.Property(e => e.ImageName).HasMaxLength(500);

        //        entity.Property(e => e.Name).HasMaxLength(500);
        //    });

        //    modelBuilder.Entity<VendorStocks>(entity =>
        //    {
        //        entity.HasKey(e => e.StockId);

        //        entity.Property(e => e.ExpectedDate).HasColumnType("datetime");
        //    });

        //    modelBuilder.Entity<Vendors>(entity =>
        //    {
        //        entity.HasKey(e => e.VendorId);

        //        entity.Property(e => e.Name).HasMaxLength(500);
        //    });

        //    modelBuilder.Entity<WishLists>(entity =>
        //    {
        //        entity.HasNoKey();

        //        entity.Property(e => e.DateAdded).HasColumnType("datetime");
        //    });

        //    OnModelCreatingPartial(modelBuilder);
        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

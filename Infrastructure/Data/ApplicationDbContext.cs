using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomUsageHistory> RoomUsageHistories { get; set; }

        public DbSet<Members> Members { get; set; }
        public DbSet<EmployeeUsage> EmployeeUsages { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomUsageHistory>()
                .HasOne(r => r.Room) // RoomUsageHistory có 1 Room
                .WithMany(h => h.histories) // Room có nhiều RoomUsageHistory
                .HasForeignKey(r => r.RoomId) // Khóa ngoại RoomId
                .OnDelete(DeleteBehavior.Cascade); // Xóa phòng thì xóa luôn lịch sử sử dụng

            modelBuilder.Entity<EmployeeUsage>()
            .HasOne(e => e.Employee) // EmployeeUsage có 1 Employee
            .WithMany(m => m.EmployeeUsages) // Employee có nhiều EmployeeUsage
            .HasForeignKey(e => e.EmployeeId) // Khóa ngoại EmployeeId
            .OnDelete(DeleteBehavior.Restrict); // Không cho phép xóa Employee
            // Cấu hình mối quan hệ giữa OrderDetails và Products
            modelBuilder.Entity<OrderDetails>()
                .HasOne(od => od.Product) // OrderDetails có 1 Product
                .WithMany() // Product không cần biết OrderDetails có bao nhiêu Product
                .HasForeignKey(od => od.ProductId);

            // Cấu hình mối quan hệ giữa OrderDetails và Orders
            modelBuilder.Entity<OrderDetails>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId);

            // Cấu hình mối quan hệ giữa Orders và RoomUsageHistory
            modelBuilder.Entity<Orders>()
                .HasOne(o => o.RoomUsage)
                .WithMany() // Orders không cần biết RoomUsage có bao nhiêu Orders
                .HasForeignKey(o => o.RoomUsageId)
                .OnDelete(DeleteBehavior.Cascade);

            // Cấu hình mối quan hệ giữa Products và Categories
            modelBuilder.Entity<Products>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

        }
    }
}

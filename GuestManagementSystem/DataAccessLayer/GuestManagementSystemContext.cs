using System;
using System.Collections.Generic;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccessLayer
{
    public partial class GuestManagementSystemContext : DbContext
    {
        public GuestManagementSystemContext()
        {
        }

        public GuestManagementSystemContext(DbContextOptions<GuestManagementSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccomodationDetail> AccomodationDetails { get; set; } = null!;
        public virtual DbSet<ConveyanceDetail> ConveyanceDetails { get; set; } = null!;
        public virtual DbSet<FoodDetail> FoodDetails { get; set; } = null!;
        public virtual DbSet<FoodMenu> FoodMenus { get; set; } = null!;
        public virtual DbSet<GuestDetail> GuestDetails { get; set; } = null!;
        public virtual DbSet<PaymentDetail> PaymentDetails { get; set; } = null!;
        public virtual DbSet<TravelDetail> TravelDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=GuestManagementSystem;persist security info=True;Integrated Security=SSPI;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccomodationDetail>(entity =>
            {
                entity.HasKey(e => e.AccomodationId)
                    .HasName("PK__Accomoda__0768F7CA026E77C5");

                entity.Property(e => e.AccomodationId).HasColumnName("AccomodationID");

                entity.Property(e => e.AccomodationType).HasMaxLength(100);

                entity.Property(e => e.AddressLine1).HasMaxLength(500);

                entity.Property(e => e.AddressLine2).HasMaxLength(500);

                entity.Property(e => e.District).HasMaxLength(100);

                entity.Property(e => e.Pin)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("PIN");

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Town).HasMaxLength(100);

                entity.Property(e => e.TravelId).HasColumnName("TravelID");

                entity.Property(e => e.TypeOfBed).HasMaxLength(50);

                entity.Property(e => e.TypeOfLocation).HasMaxLength(100);

                entity.Property(e => e.TypeOfRoom).HasMaxLength(50);

                entity.Property(e => e.UspOfTheLocation).HasMaxLength(250);

                entity.HasOne(d => d.Travel)
                    .WithMany(p => p.AccomodationDetails)
                    .HasForeignKey(d => d.TravelId)
                    .HasConstraintName("FK__Accomodat__Trave__440B1D61");
            });

            modelBuilder.Entity<ConveyanceDetail>(entity =>
            {
                entity.HasKey(e => e.ConveyanceId)
                    .HasName("PK__Conveyan__9A60C57E4B71C05E");

                entity.Property(e => e.ConveyanceId).HasColumnName("ConveyanceID");

                entity.Property(e => e.DestinationLocation).HasMaxLength(100);

                entity.Property(e => e.MediumOfConveyance).HasMaxLength(10);

                entity.Property(e => e.NameOfConveyance).HasMaxLength(100);

                entity.Property(e => e.SourceLocation).HasMaxLength(100);

                entity.Property(e => e.UniqueIdentification).HasMaxLength(50);
            });

            modelBuilder.Entity<FoodDetail>(entity =>
            {
                entity.HasKey(e => e.FoodDetailsId)
                    .HasName("PK__FoodDeta__2846641909461E90");

                entity.Property(e => e.FoodDetailsId).HasColumnName("FoodDetailsID");

                entity.Property(e => e.FoodMenuId).HasColumnName("FoodMenuID");

                entity.Property(e => e.GuestId).HasColumnName("GuestID");

                entity.Property(e => e.ServingCategory).HasMaxLength(25);

                entity.HasOne(d => d.FoodMenu)
                    .WithMany(p => p.FoodDetails)
                    .HasForeignKey(d => d.FoodMenuId)
                    .HasConstraintName("FK__FoodDetai__FoodM__5535A963");

                entity.HasOne(d => d.Guest)
                    .WithMany(p => p.FoodDetails)
                    .HasForeignKey(d => d.GuestId)
                    .HasConstraintName("FK__FoodDetai__Guest__5441852A");
            });

            modelBuilder.Entity<FoodMenu>(entity =>
            {
                entity.HasKey(e => e.MenuId)
                    .HasName("PK__FoodMenu__C99ED2508E53BDA4");

                entity.ToTable("FoodMenu");

                entity.Property(e => e.MenuId).HasColumnName("MenuID");

                entity.Property(e => e.Cost).HasColumnType("numeric(6, 2)");

                entity.Property(e => e.CuisineName).HasMaxLength(100);

                entity.Property(e => e.ItemCuisineId).HasColumnName("ItemCuisineID");

                entity.Property(e => e.ItemName).HasMaxLength(500);

                entity.HasOne(d => d.ItemCuisine)
                    .WithMany(p => p.InverseItemCuisine)
                    .HasForeignKey(d => d.ItemCuisineId)
                    .HasConstraintName("FK__FoodMenu__ItemCu__5165187F");
            });

            modelBuilder.Entity<GuestDetail>(entity =>
            {
                entity.HasKey(e => e.GuestId)
                    .HasName("PK__GuestDet__0C423C32FB443CEC");

                entity.Property(e => e.GuestId).HasColumnName("GuestID");

                entity.Property(e => e.AddressLine1).HasMaxLength(100);

                entity.Property(e => e.AddressLine2).HasMaxLength(100);

                entity.Property(e => e.District).HasMaxLength(50);

                entity.Property(e => e.EmailIdprimary)
                    .HasMaxLength(500)
                    .HasColumnName("EmailIDPrimary");

                entity.Property(e => e.EmailIdsecondary)
                    .HasMaxLength(500)
                    .HasColumnName("EmailIDSecondary");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.MobileNumberPrimary).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.MobileNumberSecondary).HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Pin)
                    .HasColumnType("numeric(6, 0)")
                    .HasColumnName("PIN");

                entity.Property(e => e.State).HasMaxLength(80);

                entity.Property(e => e.Town).HasMaxLength(50);
            });

            modelBuilder.Entity<PaymentDetail>(entity =>
            {
                entity.Property(e => e.PaymentDetailId).HasColumnName("PaymentDetailID");

                entity.Property(e => e.Amount).HasColumnType("numeric(8, 2)");

                entity.Property(e => e.DateAndTime).HasColumnType("datetime");

                entity.Property(e => e.GuestId).HasColumnName("GuestID");

                entity.Property(e => e.ModeOfPayment).HasMaxLength(50);

                entity.HasOne(d => d.Guest)
                    .WithMany(p => p.PaymentDetails)
                    .HasForeignKey(d => d.GuestId)
                    .HasConstraintName("FK__PaymentDe__Guest__5812160E");
            });

            modelBuilder.Entity<TravelDetail>(entity =>
            {
                entity.HasKey(e => e.TravelId)
                    .HasName("PK__TravelDe__E9315215ACDBF39E");

                entity.Property(e => e.TravelId).HasColumnName("TravelID");

                entity.Property(e => e.ConveyanceId).HasColumnName("ConveyanceID");

                entity.Property(e => e.DestinationLocation).HasMaxLength(100);

                entity.Property(e => e.GuestId).HasColumnName("GuestID");

                entity.Property(e => e.SourceLocation).HasMaxLength(100);

                entity.Property(e => e.TravelEndDate).HasColumnType("date");

                entity.Property(e => e.TravelStartDate).HasColumnType("date");

                entity.HasOne(d => d.Conveyance)
                    .WithMany(p => p.TravelDetails)
                    .HasForeignKey(d => d.ConveyanceId)
                    .HasConstraintName("FK__TravelDet__Conve__403A8C7D");

                entity.HasOne(d => d.Guest)
                    .WithMany(p => p.TravelDetails)
                    .HasForeignKey(d => d.GuestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TravelDet__Guest__412EB0B6");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

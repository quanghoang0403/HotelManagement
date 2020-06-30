using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QuanLyKhachSan.Models
{
    public partial class KhachSanContext : DbContext
    {
        public KhachSanContext()
        {
        }

        public KhachSanContext(DbContextOptions<KhachSanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Amount> Amount { get; set; }
        public virtual DbSet<Bill> Bill { get; set; }
        public virtual DbSet<BillDetails> BillDetails { get; set; }
        public virtual DbSet<Checkin> Checkin { get; set; }
        public virtual DbSet<CheckinDetails> CheckinDetails { get; set; }
        public virtual DbSet<CustomerType> CustomerType { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<Roomtype> Roomtype { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=KhachSan;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK__ACCOUNT__D2D146372E665AEA");

                entity.ToTable("ACCOUNT");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.DisplayName)
                    .IsRequired()
                    .HasColumnName("display_name")
                    .HasMaxLength(100);

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasColumnName("pass")
                    .HasMaxLength(1000);

                entity.Property(e => e.Permission)
                    .IsRequired()
                    .HasColumnName("permission")
                    .HasMaxLength(100);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Amount>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AMOUNT");

                entity.Property(e => e.AmountSurchage).HasColumnName("amount_surchage");

                entity.Property(e => e.CustomerRatio).HasColumnName("customer_ratio");

                entity.Property(e => e.MaxCustomer).HasColumnName("max_customer");
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.HasKey(e => e.IdBill)
                    .HasName("PK__BILL__C56081F5BBAB7A0F");

                entity.ToTable("BILL");

                entity.Property(e => e.IdBill).HasColumnName("id_bill");

                entity.Property(e => e.BillAddress)
                    .HasColumnName("bill_address")
                    .HasMaxLength(100);

                entity.Property(e => e.BillName)
                    .HasColumnName("bill_name")
                    .HasMaxLength(100);

                entity.Property(e => e.TotalMoney)
                    .HasColumnName("total_money")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<BillDetails>(entity =>
            {
                entity.HasKey(e => new { e.IdBill, e.IdCheckin });

                entity.ToTable("BILL_DETAILS");

                entity.Property(e => e.IdBill).HasColumnName("id_bill");

                entity.Property(e => e.IdCheckin).HasColumnName("id_checkin");

                entity.Property(e => e.DateNumber).HasColumnName("date_number");

                entity.Property(e => e.SurchageRatio).HasColumnName("surchage_ratio");

                entity.HasOne(d => d.IdBillNavigation)
                    .WithMany(p => p.BillDetails)
                    .HasForeignKey(d => d.IdBill)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BILL_DETA__id_bi__49C3F6B7");

                entity.HasOne(d => d.IdCheckinNavigation)
                    .WithMany(p => p.BillDetails)
                    .HasForeignKey(d => d.IdCheckin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BILL_DETA__id_ch__4AB81AF0");
            });

            modelBuilder.Entity<Checkin>(entity =>
            {
                entity.HasKey(e => e.IdCheckin)
                    .HasName("PK__CHECKIN__7E2D662E74CEEBA0");

                entity.ToTable("CHECKIN");

                entity.Property(e => e.IdCheckin).HasColumnName("id_checkin");

                entity.Property(e => e.DateStart)
                    .HasColumnName("date_start")
                    .HasColumnType("date");

                entity.Property(e => e.IdRoom)
                    .HasColumnName("id_room")
                    .HasMaxLength(100);

                entity.Property(e => e.MoneyCheckin)
                    .HasColumnName("money_checkin")
                    .HasColumnType("money");

                entity.Property(e => e.NumberCustomer).HasColumnName("number_customer");

                entity.Property(e => e.StatusCheckin)
                    .HasColumnName("status_checkin")
                    .HasMaxLength(100);

                entity.Property(e => e.TypeRatioMax).HasColumnName("type_ratioMAX");

                entity.HasOne(d => d.IdRoomNavigation)
                    .WithMany(p => p.Checkin)
                    .HasForeignKey(d => d.IdRoom)
                    .HasConstraintName("FK__CHECKIN__id_room__412EB0B6");
            });

            modelBuilder.Entity<CheckinDetails>(entity =>
            {
                entity.HasKey(e => e.IdCheckinDetails)
                    .HasName("PK__CHECKIN___B84054515CD65B00");

                entity.ToTable("CHECKIN_DETAILS");

                entity.Property(e => e.IdCheckinDetails).HasColumnName("id_checkin_details");

                entity.Property(e => e.CustomerAddress)
                    .HasColumnName("customer_address")
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerCmnd)
                    .HasColumnName("customer_cmnd")
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerName)
                    .HasColumnName("customer_name")
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerType)
                    .HasColumnName("customer_type")
                    .HasMaxLength(100);

                entity.Property(e => e.IdCheckin).HasColumnName("id_checkin");

                entity.HasOne(d => d.CustomerTypeNavigation)
                    .WithMany(p => p.CheckinDetails)
                    .HasForeignKey(d => d.CustomerType)
                    .HasConstraintName("FK__CHECKIN_D__custo__440B1D61");

                entity.HasOne(d => d.IdCheckinNavigation)
                    .WithMany(p => p.CheckinDetails)
                    .HasForeignKey(d => d.IdCheckin)
                    .HasConstraintName("FK__CHECKIN_D__id_ch__44FF419A");
            });

            modelBuilder.Entity<CustomerType>(entity =>
            {
                entity.HasKey(e => e.CustomerType1)
                    .HasName("PK__CUSTOMER__E8F2052BDAE9778C");

                entity.ToTable("CUSTOMER_TYPE");

                entity.Property(e => e.CustomerType1)
                    .HasColumnName("customer_type")
                    .HasMaxLength(100);

                entity.Property(e => e.Ratio).HasColumnName("ratio");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.HasKey(e => e.IdRoom)
                    .HasName("PK__ROOM__3D497891AE2F1158");

                entity.ToTable("ROOM");

                entity.Property(e => e.IdRoom)
                    .HasColumnName("id_room")
                    .HasMaxLength(100);

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .HasMaxLength(100);

                entity.Property(e => e.RoomType)
                    .IsRequired()
                    .HasColumnName("room_type")
                    .HasMaxLength(100);

                entity.Property(e => e.Statuss)
                    .HasColumnName("statuss")
                    .HasMaxLength(100);

                entity.HasOne(d => d.RoomTypeNavigation)
                    .WithMany(p => p.Room)
                    .HasForeignKey(d => d.RoomType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ROOM__room_type__3C69FB99");
            });

            modelBuilder.Entity<Roomtype>(entity =>
            {
                entity.HasKey(e => e.RoomType1)
                    .HasName("PK__ROOMTYPE__4E0C7934C700FA23");

                entity.ToTable("ROOMTYPE");

                entity.Property(e => e.RoomType1)
                    .HasColumnName("room_type")
                    .HasMaxLength(100);

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("money");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

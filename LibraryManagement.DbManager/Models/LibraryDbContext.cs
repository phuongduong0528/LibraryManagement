namespace LibraryManagement.DbManager.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LibraryDbContext : DbContext
    {
        public LibraryDbContext()
            : base("name=LibraryDbContext2")
        {
        }

        public virtual DbSet<DauSach> DauSaches { get; set; }
        public virtual DbSet<DocGia> DocGias { get; set; }
        public virtual DbSet<DongPhieuMuon> DongPhieuMuons { get; set; }
        public virtual DbSet<NguoiQL> NguoiQLs { get; set; }
        public virtual DbSet<NhaXuatBan> NhaXuatBans { get; set; }
        public virtual DbSet<PhieuMuon> PhieuMuons { get; set; }
        public virtual DbSet<QuyenSach> QuyenSaches { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<TacGia> TacGias { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DauSach>()
                .Property(e => e.KeSach)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DauSach>()
                .HasMany(e => e.QuyenSaches)
                .WithOptional(e => e.DauSach)
                .HasForeignKey(e => e.IDDauSach);

            modelBuilder.Entity<DocGia>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .Property(e => e.MaSV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .Property(e => e.MatKhau)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DocGia>()
                .HasMany(e => e.PhieuMuons)
                .WithOptional(e => e.DocGia)
                .HasForeignKey(e => e.IDDocGia);

            modelBuilder.Entity<NguoiQL>()
                .Property(e => e.ID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NguoiQL>()
                .Property(e => e.MatKhau)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NguoiQL>()
                .HasMany(e => e.PhieuMuons)
                .WithOptional(e => e.NguoiQL)
                .HasForeignKey(e => e.IDNguoiQL);

            modelBuilder.Entity<NhaXuatBan>()
                .HasMany(e => e.DauSaches)
                .WithOptional(e => e.NhaXuatBan)
                .HasForeignKey(e => e.IDNhaXuatBan);

            modelBuilder.Entity<PhieuMuon>()
                .Property(e => e.IDNguoiQL)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuMuon>()
                .Property(e => e.IDDocGia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuMuon>()
                .HasMany(e => e.DongPhieuMuons)
                .WithOptional(e => e.PhieuMuon)
                .HasForeignKey(e => e.IDPhieuMuon);

            modelBuilder.Entity<QuyenSach>()
                .HasMany(e => e.DongPhieuMuons)
                .WithOptional(e => e.QuyenSach)
                .HasForeignKey(e => e.IDQuyenSach);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.MaSV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TacGia>()
                .HasMany(e => e.DauSaches)
                .WithOptional(e => e.TacGia)
                .HasForeignKey(e => e.IDTacGia);

            modelBuilder.Entity<TheLoai>()
                .HasMany(e => e.DauSaches)
                .WithOptional(e => e.TheLoai)
                .HasForeignKey(e => e.IDTheLoai);
        }
    }
}

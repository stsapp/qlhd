namespace QLHD.Data.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLHDDbContext : DbContext
    {
        public QLHDDbContext()
            : base("name=QLHDDbContext")
        {
        }

        public virtual DbSet<dmhuongdan> dmhuongdans { get; set; }
        public virtual DbSet<doituong> doituongs { get; set; }
        public virtual DbSet<Error> Errors { get; set; }
        public virtual DbSet<loaitour> loaitours { get; set; }
        public virtual DbSet<login> logins { get; set; }
        public virtual DbSet<phep> pheps { get; set; }
        public virtual DbSet<quyettoandoan> quyettoandoans { get; set; }
        public virtual DbSet<tamung> tamungs { get; set; }
        public virtual DbSet<tour> tours { get; set; }
        public virtual DbSet<tourhuongdan> tourhuongdans { get; set; }
        public virtual DbSet<tourKhach> tourKhaches { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<dmhuongdan>()
                .Property(e => e.mahd)
                .IsUnicode(false);

            modelBuilder.Entity<dmhuongdan>()
                .Property(e => e.tendn)
                .IsUnicode(false);

            modelBuilder.Entity<dmhuongdan>()
                .Property(e => e.socmnd)
                .IsUnicode(false);

            modelBuilder.Entity<dmhuongdan>()
                .Property(e => e.dienthoaidd)
                .IsUnicode(false);

            modelBuilder.Entity<dmhuongdan>()
                .Property(e => e.dienthoainha)
                .IsUnicode(false);

            modelBuilder.Entity<dmhuongdan>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<dmhuongdan>()
                .Property(e => e.kinhnghiem)
                .IsUnicode(false);

            modelBuilder.Entity<dmhuongdan>()
                .Property(e => e.sothehdv)
                .IsUnicode(false);

            modelBuilder.Entity<dmhuongdan>()
                .Property(e => e.hochieu)
                .IsUnicode(false);

            modelBuilder.Entity<dmhuongdan>()
                .Property(e => e.chinhanh)
                .IsUnicode(false);

            modelBuilder.Entity<dmhuongdan>()
                .Property(e => e.dtquanhe)
                .IsUnicode(false);

            modelBuilder.Entity<dmhuongdan>()
                .HasMany(e => e.pheps)
                .WithRequired(e => e.dmhuongdan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<dmhuongdan>()
                .HasMany(e => e.tamungs)
                .WithRequired(e => e.dmhuongdan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<doituong>()
                .Property(e => e.madoituong)
                .IsUnicode(false);

            modelBuilder.Entity<login>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<login>()
                .Property(e => e.passmail)
                .IsUnicode(false);

            modelBuilder.Entity<login>()
                .Property(e => e.mahd)
                .IsUnicode(false);

            modelBuilder.Entity<phep>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<phep>()
                .Property(e => e.mahd)
                .IsUnicode(false);

            modelBuilder.Entity<quyettoandoan>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<quyettoandoan>()
                .Property(e => e.CodeDoan)
                .IsUnicode(false);

            modelBuilder.Entity<quyettoandoan>()
                .Property(e => e.mahd)
                .IsUnicode(false);

            modelBuilder.Entity<quyettoandoan>()
                .Property(e => e.phieutamung)
                .IsUnicode(false);

            modelBuilder.Entity<quyettoandoan>()
                .Property(e => e.sotien)
                .HasPrecision(10, 2);

            modelBuilder.Entity<quyettoandoan>()
                .Property(e => e.loaitien)
                .IsUnicode(false);

            modelBuilder.Entity<quyettoandoan>()
                .Property(e => e.tigia)
                .HasPrecision(8, 2);

            modelBuilder.Entity<quyettoandoan>()
                .Property(e => e.tienvnd)
                .HasPrecision(10, 2);

            modelBuilder.Entity<quyettoandoan>()
                .Property(e => e.phieuhoanung)
                .IsUnicode(false);

            modelBuilder.Entity<tamung>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tamung>()
                .Property(e => e.mahd)
                .IsUnicode(false);

            modelBuilder.Entity<tamung>()
                .Property(e => e.sotien)
                .HasPrecision(10, 2);

            modelBuilder.Entity<tamung>()
                .Property(e => e.sotienhoanung)
                .HasPrecision(10, 2);

            modelBuilder.Entity<tour>()
                .Property(e => e.sic)
                .IsUnicode(false);

            modelBuilder.Entity<tour>()
                .Property(e => e.sgtCode)
                .IsUnicode(false);

            modelBuilder.Entity<tour>()
                .Property(e => e.codeKhach)
                .IsUnicode(false);

            modelBuilder.Entity<tourhuongdan>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tourhuongdan>()
                .Property(e => e.sic)
                .IsUnicode(false);

            modelBuilder.Entity<tourhuongdan>()
                .Property(e => e.sgtCode)
                .IsUnicode(false);

            modelBuilder.Entity<tourhuongdan>()
                .Property(e => e.mahd)
                .IsUnicode(false);

            modelBuilder.Entity<tourhuongdan>()
                .Property(e => e.giobatdau)
                .IsUnicode(false);

            modelBuilder.Entity<tourhuongdan>()
                .Property(e => e.gioketthuc)
                .IsUnicode(false);

            modelBuilder.Entity<tourKhach>()
                .Property(e => e.Id)
                .HasPrecision(18, 0);

            modelBuilder.Entity<tourKhach>()
                .Property(e => e.sic)
                .IsUnicode(false);

            modelBuilder.Entity<tourKhach>()
                .Property(e => e.sgtCode)
                .IsUnicode(false);

            modelBuilder.Entity<tourKhach>()
                .Property(e => e.dienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<tourKhach>()
                .Property(e => e.hochieu)
                .IsUnicode(false);
        }
    }
}

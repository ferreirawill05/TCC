using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using senai.darede.WebAPI.Domains;

#nullable disable

namespace senai.darede.WebAPI.Contexts
{
    public partial class DaredeContext : DbContext
    {
        public DaredeContext()
        {
        }

        public DaredeContext(DbContextOptions<DaredeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ArmInstancium> ArmInstancia { get; set; }
        public virtual DbSet<Infraestrutura> Infraestruturas { get; set; }
        public virtual DbSet<Instancium> Instancia { get; set; }
        public virtual DbSet<Software> Softwares { get; set; }
        public virtual DbSet<TipoInstancium> TipoInstancia { get; set; }
        public virtual DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Zona> Zonas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
/*#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263. */
                optionsBuilder.UseSqlServer("Data Source=servidor-darede-2.database.windows.net; initial catalog=darede_db; user Id=darede-ju; pwd=senai@132; ");
    
}
}

protected override void OnModelCreating(ModelBuilder modelBuilder)
{
modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

modelBuilder.Entity<ArmInstancium>(entity =>
{
entity.HasKey(e => e.IdArmInstancia)
    .HasName("PK__armInsta__6E3195AE744F147F");

entity.ToTable("armInstancia");

entity.HasIndex(e => e.TipoArmInstancia, "UQ__armInsta__6968B611499F46F9")
    .IsUnique();

entity.Property(e => e.IdArmInstancia)
    .ValueGeneratedOnAdd()
    .HasColumnName("idArmInstancia");

entity.Property(e => e.TipoArmInstancia)
    .IsRequired()
    .HasMaxLength(30)
    .IsUnicode(false)
    .HasColumnName("tipoArmInstancia");
});

modelBuilder.Entity<Infraestrutura>(entity =>
{
entity.HasKey(e => e.IdInfraestrutura)
    .HasName("PK__infraest__973745E910C54D5E");

entity.ToTable("infraestrutura");

entity.HasIndex(e => e.IpPublico, "UQ__infraest__3A52E6DF6DBE5A66")
    .IsUnique();

entity.HasIndex(e => e.IpPrivado, "UQ__infraest__497E8014A5313950")
    .IsUnique();

entity.Property(e => e.IdInfraestrutura).HasColumnName("idInfraestrutura");

entity.Property(e => e.Ativo)
    .IsRequired()
    .HasColumnName("ativo")
    .HasDefaultValueSql("((1))");

entity.Property(e => e.Gateway)
    .IsRequired()
    .HasMaxLength(20)
    .IsUnicode(false)
    .HasColumnName("gateway");

entity.Property(e => e.IdInstancia).HasColumnName("idInstancia");

entity.Property(e => e.IdSoftware).HasColumnName("idSoftware");

entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

entity.Property(e => e.IdZona).HasColumnName("idZona");

entity.Property(e => e.IpPrivado)
    .IsRequired()
    .HasMaxLength(20)
    .IsUnicode(false)
    .HasColumnName("ipPrivado");

entity.Property(e => e.IpPublico)
    .IsRequired()
    .HasMaxLength(20)
    .IsUnicode(false)
    .HasColumnName("ipPublico");

entity.Property(e => e.MascaraGateway)
    .IsRequired()
    .HasMaxLength(15)
    .IsUnicode(false)
    .HasColumnName("mascaraGateway");

entity.Property(e => e.MascaraPrivado)
    .IsRequired()
    .HasMaxLength(15)
    .IsUnicode(false)
    .HasColumnName("mascaraPrivado");

entity.Property(e => e.MascaraPublico)
    .IsRequired()
    .HasMaxLength(15)
    .IsUnicode(false)
    .HasColumnName("mascaraPublico");

entity.Property(e => e.TopologiaImagem)
    .IsRequired()
    .HasMaxLength(256)
    .IsUnicode(false)
    .HasColumnName("topologiaImagem");

entity.HasOne(d => d.IdInstanciaNavigation)
    .WithMany(p => p.Infraestruturas)
    .HasForeignKey(d => d.IdInstancia)
    .HasConstraintName("FK__infraestr__idIns__3D5E1FD2");

entity.HasOne(d => d.IdSoftwareNavigation)
    .WithMany(p => p.Infraestruturas)
    .HasForeignKey(d => d.IdSoftware)
    .HasConstraintName("FK__infraestr__idSof__3E52440B");

entity.HasOne(d => d.IdUsuarioNavigation)
    .WithMany(p => p.Infraestruturas)
    .HasForeignKey(d => d.IdUsuario)
    .HasConstraintName("FK__infraestr__idUsu__3C69FB99");

entity.HasOne(d => d.IdZonaNavigation)
    .WithMany(p => p.Infraestruturas)
    .HasForeignKey(d => d.IdZona)
    .HasConstraintName("FK__infraestr__idZon__3F466844");
});

modelBuilder.Entity<Instancium>(entity =>
{
entity.HasKey(e => e.IdInstancia)
    .HasName("PK__instanci__1D55BE1AA66F0094");

entity.ToTable("instancia");

entity.Property(e => e.IdInstancia).HasColumnName("idInstancia");

entity.Property(e => e.IdArmInstancia).HasColumnName("idArmInstancia");

entity.Property(e => e.IdTipoInstancia).HasColumnName("idTipoInstancia");

entity.Property(e => e.MemoriaGib)
    .IsRequired()
    .HasMaxLength(50)
    .IsUnicode(false)
    .HasColumnName("memoriaGIB");

entity.Property(e => e.VCpu)
    .IsRequired()
    .HasMaxLength(50)
    .IsUnicode(false)
    .HasColumnName("vCPU");

entity.HasOne(d => d.IdArmInstanciaNavigation)
    .WithMany(p => p.Instancia)
    .HasForeignKey(d => d.IdArmInstancia)
    .HasConstraintName("FK__instancia__idArm__36B12243");

entity.HasOne(d => d.IdTipoInstanciaNavigation)
    .WithMany(p => p.Instancia)
    .HasForeignKey(d => d.IdTipoInstancia)
    .HasConstraintName("FK__instancia__idTip__37A5467C");
});

modelBuilder.Entity<Software>(entity =>
{
entity.HasKey(e => e.IdSoftware)
    .HasName("PK__software__35D1563D19870CBE");

entity.ToTable("software");

entity.HasIndex(e => e.NomeSoftware, "UQ__software__5BDFDAAFD9CD4298")
    .IsUnique();

entity.Property(e => e.IdSoftware)
    .ValueGeneratedOnAdd()
    .HasColumnName("idSoftware");

entity.Property(e => e.NomeSoftware)
    .IsRequired()
    .HasMaxLength(100)
    .IsUnicode(false)
    .HasColumnName("nomeSoftware");
});

modelBuilder.Entity<TipoInstancium>(entity =>
{
entity.HasKey(e => e.IdTipoInstancia)
    .HasName("PK__tipoInst__BFADCEC1BE9F0949");

entity.ToTable("tipoInstancia");

entity.HasIndex(e => e.NomeTipoInstancia, "UQ__tipoInst__34C948671B8740D3")
    .IsUnique();

entity.Property(e => e.IdTipoInstancia).HasColumnName("idTipoInstancia");

entity.Property(e => e.NomeTipoInstancia)
    .IsRequired()
    .HasMaxLength(256)
    .IsUnicode(false)
    .HasColumnName("nomeTipoInstancia");
});

modelBuilder.Entity<TipoUsuario>(entity =>
{
entity.HasKey(e => e.IdTipoUsuario)
    .HasName("PK__tipoUsua__03006BFF19D896B8");

entity.ToTable("tipoUsuario");

entity.HasIndex(e => e.NomeTipoUsuario, "UQ__tipoUsua__A017BD9FC6EE3F98")
    .IsUnique();

entity.Property(e => e.IdTipoUsuario)
    .ValueGeneratedOnAdd()
    .HasColumnName("idTipoUsuario");

entity.Property(e => e.NomeTipoUsuario)
    .IsRequired()
    .HasMaxLength(15)
    .IsUnicode(false)
    .HasColumnName("nomeTipoUsuario");
});

modelBuilder.Entity<Usuario>(entity =>
{
entity.HasKey(e => e.IdUsuario)
    .HasName("PK__usuario__645723A646D177BB");

entity.ToTable("usuario");

entity.HasIndex(e => e.Email, "UQ__usuario__AB6E61645C25F74A")
    .IsUnique();

entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

entity.Property(e => e.Email)
    .IsRequired()
    .HasMaxLength(256)
    .IsUnicode(false)
    .HasColumnName("email");

entity.Property(e => e.IdTipoUsuario).HasColumnName("idTipoUsuario");

entity.Property(e => e.NomeUsuario)
    .IsRequired()
    .HasMaxLength(256)
    .IsUnicode(false)
    .HasColumnName("nomeUsuario");

entity.Property(e => e.Senha)
    .IsRequired()
    .HasMaxLength(50)
    .IsUnicode(false)
    .HasColumnName("senha");

entity.HasOne(d => d.IdTipoUsuarioNavigation)
    .WithMany(p => p.Usuarios)
    .HasForeignKey(d => d.IdTipoUsuario)
    .HasConstraintName("FK__usuario__idTipoU__286302EC");
});

modelBuilder.Entity<Zona>(entity =>
{
entity.HasKey(e => e.IdZona)
    .HasName("PK__zona__1EE4D75CD4B9DE3D");

entity.ToTable("zona");

entity.HasIndex(e => e.NomeZona, "UQ__zona__A49AE9CE1FCA3D56")
    .IsUnique();

entity.Property(e => e.IdZona)
    .ValueGeneratedOnAdd()
    .HasColumnName("idZona");

entity.Property(e => e.NomeZona)
    .IsRequired()
    .HasMaxLength(30)
    .IsUnicode(false)
    .HasColumnName("nomeZona");
});

OnModelCreatingPartial(modelBuilder);
}

partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
}

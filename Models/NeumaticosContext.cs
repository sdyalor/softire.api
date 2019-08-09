using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace softire.api.Models
{
    public partial class NeumaticosContext : DbContext
    {
        public NeumaticosContext()
        {
        }

        public NeumaticosContext(DbContextOptions<NeumaticosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<SnCiaNeumatico> SnCiaNeumatico { get; set; }
        public virtual DbSet<SnCondicionesNeumatico> SnCondicionesNeumatico { get; set; }
        public virtual DbSet<SnConfiguracion> SnConfiguracion { get; set; }
        public virtual DbSet<SnDisenosNeumatico> SnDisenosNeumatico { get; set; }
        public virtual DbSet<SnMarcaNeumatico> SnMarcaNeumatico { get; set; }
        public virtual DbSet<SnMarcaVehiculo> SnMarcaVehiculo { get; set; }
        public virtual DbSet<SnMedidaNeumatico> SnMedidaNeumatico { get; set; }
        public virtual DbSet<SnModeloNeumatico> SnModeloNeumatico { get; set; }
        public virtual DbSet<SnModeloVehiculo> SnModeloVehiculo { get; set; }
        public virtual DbSet<SnNeumaticos> SnNeumaticos { get; set; }
        public virtual DbSet<SnNeumaticosDet> SnNeumaticosDet { get; set; }
        public virtual DbSet<SnObraNeumatico> SnObraNeumatico { get; set; }
        public virtual DbSet<SnParametrosNeuma> SnParametrosNeuma { get; set; }
        public virtual DbSet<SnProveedores> SnProveedores { get; set; }
        public virtual DbSet<SnTipoVehiculo> SnTipoVehiculo { get; set; }
        public virtual DbSet<SnVehiculo> SnVehiculo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=sqlcmd.c5hj5b0jux9f.us-east-1.rds.amazonaws.com;Database=neumaticos2;User id=sdyalor;Password=15362486957");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SnCiaNeumatico>(entity =>
            {
                entity.HasKey(e => e.CodCia);

                entity.ToTable("SN_Cia_Neumatico");

                entity.Property(e => e.CodCia)
                    .HasColumnName("COD_CIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Breve)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Notas)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SnCondicionesNeumatico>(entity =>
            {
                entity.HasKey(e => new { e.CodCia, e.CodCondicion })
                    .HasName("PK_SN_Condiciones_Neumatico_1");

                entity.ToTable("SN_Condiciones_Neumatico");

                entity.Property(e => e.CodCia)
                    .HasColumnName("COD_CIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodCondicion)
                    .HasColumnName("Cod_Condicion")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Breve)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Notas)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodCiaNavigation)
                    .WithMany(p => p.SnCondicionesNeumatico)
                    .HasForeignKey(d => d.CodCia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_Condiciones_Neumatico_SN_Cia_Neumatico");
            });

            modelBuilder.Entity<SnConfiguracion>(entity =>
            {
                entity.HasKey(e => new { e.CodCia, e.CodConfi });

                entity.ToTable("SN_Configuracion");

                entity.Property(e => e.CodCia)
                    .HasColumnName("COD_CIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodConfi)
                    .HasColumnName("COD_CONFI")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Breve)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Coro01)
                    .HasColumnName("CORO01")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Coro010)
                    .HasColumnName("CORO010")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Coro02)
                    .HasColumnName("CORO02")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Coro03)
                    .HasColumnName("CORO03")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Coro04)
                    .HasColumnName("CORO04")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Coro05)
                    .HasColumnName("CORO05")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Coro06)
                    .HasColumnName("CORO06")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Coro07)
                    .HasColumnName("CORO07")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Coro08)
                    .HasColumnName("CORO08")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Coro09)
                    .HasColumnName("CORO09")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Coro10)
                    .HasColumnName("CORO10")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Eje01)
                    .HasColumnName("EJE01")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Eje010)
                    .HasColumnName("EJE010")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Eje02)
                    .HasColumnName("EJE02")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Eje03)
                    .HasColumnName("EJE03")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Eje04)
                    .HasColumnName("EJE04")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Eje05)
                    .HasColumnName("EJE05")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Eje06)
                    .HasColumnName("EJE06")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Eje07)
                    .HasColumnName("EJE07")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Eje08)
                    .HasColumnName("EJE08")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Eje09)
                    .HasColumnName("EJE09")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Eje10)
                    .HasColumnName("EJE10")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Foto1001)
                    .HasColumnName("FOTO1001")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto1002)
                    .HasColumnName("FOTO1002")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto1003)
                    .HasColumnName("FOTO1003")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto1004)
                    .HasColumnName("FOTO1004")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto1005)
                    .HasColumnName("FOTO1005")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto1006)
                    .HasColumnName("FOTO1006")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto1007)
                    .HasColumnName("FOTO1007")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto1008)
                    .HasColumnName("FOTO1008")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto101)
                    .HasColumnName("FOTO101")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto102)
                    .HasColumnName("FOTO102")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto103)
                    .HasColumnName("FOTO103")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto104)
                    .HasColumnName("FOTO104")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto105)
                    .HasColumnName("FOTO105")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto106)
                    .HasColumnName("FOTO106")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto107)
                    .HasColumnName("FOTO107")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto108)
                    .HasColumnName("FOTO108")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto201)
                    .HasColumnName("FOTO201")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto202)
                    .HasColumnName("FOTO202")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto203)
                    .HasColumnName("FOTO203")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto204)
                    .HasColumnName("FOTO204")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto205)
                    .HasColumnName("FOTO205")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto206)
                    .HasColumnName("FOTO206")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto207)
                    .HasColumnName("FOTO207")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto208)
                    .HasColumnName("FOTO208")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto301)
                    .HasColumnName("FOTO301")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto302)
                    .HasColumnName("FOTO302")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto303)
                    .HasColumnName("FOTO303")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto304)
                    .HasColumnName("FOTO304")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto305)
                    .HasColumnName("FOTO305")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto306)
                    .HasColumnName("FOTO306")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto307)
                    .HasColumnName("FOTO307")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto308)
                    .HasColumnName("FOTO308")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto401)
                    .HasColumnName("FOTO401")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto402)
                    .HasColumnName("FOTO402")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto403)
                    .HasColumnName("FOTO403")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto404)
                    .HasColumnName("FOTO404")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto405)
                    .HasColumnName("FOTO405")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto406)
                    .HasColumnName("FOTO406")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto407)
                    .HasColumnName("FOTO407")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto408)
                    .HasColumnName("FOTO408")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto501)
                    .HasColumnName("FOTO501")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto502)
                    .HasColumnName("FOTO502")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto503)
                    .HasColumnName("FOTO503")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto504)
                    .HasColumnName("FOTO504")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto505)
                    .HasColumnName("FOTO505")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto506)
                    .HasColumnName("FOTO506")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto507)
                    .HasColumnName("FOTO507")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto508)
                    .HasColumnName("FOTO508")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto601)
                    .HasColumnName("FOTO601")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto602)
                    .HasColumnName("FOTO602")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto603)
                    .HasColumnName("FOTO603")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto604)
                    .HasColumnName("FOTO604")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto605)
                    .HasColumnName("FOTO605")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto606)
                    .HasColumnName("FOTO606")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto607)
                    .HasColumnName("FOTO607")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto608)
                    .HasColumnName("FOTO608")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto701)
                    .HasColumnName("FOTO701")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto702)
                    .HasColumnName("FOTO702")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto703)
                    .HasColumnName("FOTO703")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto704)
                    .HasColumnName("FOTO704")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto705)
                    .HasColumnName("FOTO705")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto706)
                    .HasColumnName("FOTO706")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto707)
                    .HasColumnName("FOTO707")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto708)
                    .HasColumnName("FOTO708")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto801)
                    .HasColumnName("FOTO801")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto802)
                    .HasColumnName("FOTO802")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto803)
                    .HasColumnName("FOTO803")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto804)
                    .HasColumnName("FOTO804")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto805)
                    .HasColumnName("FOTO805")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto806)
                    .HasColumnName("FOTO806")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto807)
                    .HasColumnName("FOTO807")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto808)
                    .HasColumnName("FOTO808")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto901)
                    .HasColumnName("FOTO901")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto902)
                    .HasColumnName("FOTO902")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto903)
                    .HasColumnName("FOTO903")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto904)
                    .HasColumnName("FOTO904")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto905)
                    .HasColumnName("FOTO905")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto906)
                    .HasColumnName("FOTO906")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto907)
                    .HasColumnName("FOTO907")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Foto908)
                    .HasColumnName("FOTO908")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Fotor01)
                    .HasColumnName("FOTOR01")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Fotor02)
                    .HasColumnName("FOTOR02")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Fotor03)
                    .HasColumnName("FOTOR03")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.Fotor04)
                    .HasColumnName("FOTOR04")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.N1001).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N1002).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N1003).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N1004).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N1005).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N1006).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N1007).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N1008).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N101).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N102).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N103).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N104).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N105).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N106).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N107).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N108).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N201).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N202).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N203).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N204).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N205).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N206).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N207).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N208).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N301).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N302).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N303).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N304).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N305).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N306).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N307).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N308).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N401).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N402).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N403).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N404).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N405).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N406).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N407).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N408).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N501).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N502).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N503).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N504).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N505).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N506).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N507).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N508).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N601).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N602).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N603).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N604).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N605).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N606).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N607).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N608).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N701).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N702).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N703).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N704).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N705).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N706).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N707).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N708).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N801).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N802).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N803).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N804).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N805).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N806).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N807).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N808).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N901).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N902).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N903).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N904).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N905).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N906).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N907).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.N908).HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Nota)
                    .HasColumnName("NOTA")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Nr01)
                    .HasColumnName("NR01")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Nr02)
                    .HasColumnName("NR02")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Nr03)
                    .HasColumnName("NR03")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Nr04)
                    .HasColumnName("NR04")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.TipoEje01)
                    .HasColumnName("TIPO_EJE01")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoEje02)
                    .HasColumnName("TIPO_EJE02")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoEje03)
                    .HasColumnName("TIPO_EJE03")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoEje04)
                    .HasColumnName("TIPO_EJE04")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoEje05)
                    .HasColumnName("TIPO_EJE05")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoEje06)
                    .HasColumnName("TIPO_EJE06")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoEje07)
                    .HasColumnName("TIPO_EJE07")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoEje08)
                    .HasColumnName("TIPO_EJE08")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoEje09)
                    .HasColumnName("TIPO_EJE09")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.TipoEje10)
                    .HasColumnName("TIPO_EJE10")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Usuario)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodCiaNavigation)
                    .WithMany(p => p.SnConfiguracion)
                    .HasForeignKey(d => d.CodCia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_Configuracion_SN_Cia_Neumatico");
            });

            modelBuilder.Entity<SnDisenosNeumatico>(entity =>
            {
                entity.HasKey(e => new { e.CodCia, e.CodDiseno })
                    .HasName("PK_SN_Disenos_Neumatico_1");

                entity.ToTable("SN_Disenos_Neumatico");

                entity.Property(e => e.CodCia)
                    .HasColumnName("COD_CIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodDiseno)
                    .HasColumnName("COD_Diseno")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Breve)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Notas)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodCiaNavigation)
                    .WithMany(p => p.SnDisenosNeumatico)
                    .HasForeignKey(d => d.CodCia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_DISENOS_SN_Cia_Neumatico");
            });

            modelBuilder.Entity<SnMarcaNeumatico>(entity =>
            {
                entity.HasKey(e => new { e.CodCia, e.CodMarca });

                entity.ToTable("SN_Marca_Neumatico");

                entity.Property(e => e.CodCia)
                    .HasColumnName("COD_CIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodMarca)
                    .HasColumnName("COD_MARCA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Breve)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Notas)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodCiaNavigation)
                    .WithMany(p => p.SnMarcaNeumatico)
                    .HasForeignKey(d => d.CodCia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_Marca_Neumatico_SN_Cia_Neumatico");
            });

            modelBuilder.Entity<SnMarcaVehiculo>(entity =>
            {
                entity.HasKey(e => new { e.CodCia, e.CodMarca })
                    .HasName("PK_SN_Marca_Vehiculo_1");

                entity.ToTable("SN_Marca_Vehiculo");

                entity.Property(e => e.CodCia)
                    .HasColumnName("COD_CIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodMarca)
                    .HasColumnName("COD_Marca")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Breve)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Notas)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SnMedidaNeumatico>(entity =>
            {
                entity.HasKey(e => new { e.CodCia, e.CodMedida });

                entity.ToTable("SN_Medida_Neumatico");

                entity.Property(e => e.CodCia)
                    .HasColumnName("COD_CIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodMedida)
                    .HasColumnName("COD_Medida")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Breve)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Notas)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodCiaNavigation)
                    .WithMany(p => p.SnMedidaNeumatico)
                    .HasForeignKey(d => d.CodCia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_Medida_SN_Cia_Neumatico");
            });

            modelBuilder.Entity<SnModeloNeumatico>(entity =>
            {
                entity.HasKey(e => new { e.CodCia, e.CodMarca, e.CodModelo });

                entity.ToTable("SN_Modelo_Neumatico");

                entity.Property(e => e.CodCia)
                    .HasColumnName("COD_CIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodMarca)
                    .HasColumnName("COD_MARCA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodModelo)
                    .HasColumnName("COD_MODELO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Breve)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Notas)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodCiaNavigation)
                    .WithMany(p => p.SnModeloNeumatico)
                    .HasForeignKey(d => d.CodCia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_Modelo_Neumatico_SN_Cia_Neumatico");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.SnModeloNeumatico)
                    .HasForeignKey(d => new { d.CodCia, d.CodMarca })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_Modelo_Neumatico_SN_Marca_Neumatico");
            });

            modelBuilder.Entity<SnModeloVehiculo>(entity =>
            {
                entity.HasKey(e => new { e.CodCia, e.CodMarca, e.CodModelo })
                    .HasName("PK_SN_Modelo_Vehiculo_1");

                entity.ToTable("SN_Modelo_Vehiculo");

                entity.Property(e => e.CodCia)
                    .HasColumnName("COD_CIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodMarca)
                    .HasColumnName("COD_Marca")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodModelo)
                    .HasColumnName("COD_Modelo")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Breve)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idcarga).HasColumnName("IDCARGA");

                entity.Property(e => e.Notas)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodCiaNavigation)
                    .WithMany(p => p.SnModeloVehiculo)
                    .HasForeignKey(d => d.CodCia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_Modelo_Vehiculo_SN_Cia_Neumatico");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.SnModeloVehiculo)
                    .HasForeignKey(d => new { d.CodCia, d.CodMarca })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_Modelo_Vehiculo_SN_Marca_Vehiculo");
            });

            modelBuilder.Entity<SnNeumaticos>(entity =>
            {
                entity.HasKey(e => new { e.CodCia, e.CodObra, e.CodNeumatico });

                entity.ToTable("SN_Neumaticos");

                entity.Property(e => e.CodCia)
                    .HasColumnName("COD_CIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodObra)
                    .HasColumnName("COD_OBRA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodNeumatico)
                    .HasColumnName("COD_Neumatico")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CheckPoint)
                    .HasColumnName("check_point")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodCausa)
                    .HasColumnName("cod_causa")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodDiseno)
                    .HasColumnName("Cod_Diseno")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodMarca)
                    .HasColumnName("Cod_Marca")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodMedida)
                    .HasColumnName("Cod_Medida")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodModelo)
                    .HasColumnName("Cod_Modelo")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodMotivoBaja)
                    .HasColumnName("Cod_Motivo_Baja")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodProveedor)
                    .HasColumnName("Cod_Proveedor")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.DotSerie)
                    .HasColumnName("Dot_Serie")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.ExtencionValvula)
                    .HasColumnName("Extencion_Valvula")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FecIngAlma)
                    .HasColumnName("Fec_Ing_Alma")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaCompra)
                    .HasColumnName("Fecha_Compra")
                    .HasColumnType("datetime");

                entity.Property(e => e.Idcarga)
                    .HasColumnName("idcarga")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Linecarga).HasColumnName("linecarga");

                entity.Property(e => e.Notas)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NroDocu)
                    .HasColumnName("Nro_Docu")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NroPlieges).HasColumnName("nro_plieges");

                entity.Property(e => e.NroRequ)
                    .HasColumnName("Nro_Requ")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioCompra)
                    .HasColumnName("Precio_Compra")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Rem1).HasColumnName("rem1");

                entity.Property(e => e.Rem2).HasColumnName("rem2");

                entity.Property(e => e.Rem3).HasColumnName("rem3");

                entity.Property(e => e.RemanenteIni)
                    .HasColumnName("Remanente_Ini")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.RemanenteInicial)
                    .HasColumnName("Remanente_inicial")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.RemanenteMinima)
                    .HasColumnName("Remanente_Minima")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.RemanenteProm)
                    .HasColumnName("Remanente_Prom")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.TapaValvula)
                    .HasColumnName("Tapa_Valvula")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZonaAveria)
                    .HasColumnName("zona_averia")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodCiaNavigation)
                    .WithMany(p => p.SnNeumaticos)
                    .HasForeignKey(d => d.CodCia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_Neumaticos_SN_Cia_Neumatico");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.SnNeumaticos)
                    .HasForeignKey(d => new { d.CodCia, d.CodDiseno })
                    .HasConstraintName("FK_SN_Neumaticos_SN_Disenos_Neumatico");

                entity.HasOne(d => d.CodNavigation)
                    .WithMany(p => p.SnNeumaticos)
                    .HasForeignKey(d => new { d.CodCia, d.CodMarca })
                    .HasConstraintName("FK_SN_Neumaticos_SN_Marca_Neumatico");

                entity.HasOne(d => d.Cod1)
                    .WithMany(p => p.SnNeumaticos)
                    .HasForeignKey(d => new { d.CodCia, d.CodMedida })
                    .HasConstraintName("FK_SN_Neumaticos_SN_Medida_Neumatico");

                entity.HasOne(d => d.Cod2)
                    .WithMany(p => p.SnNeumaticos)
                    .HasForeignKey(d => new { d.CodCia, d.CodObra })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_Neumaticos_SN_Obra_Neumatico");

                entity.HasOne(d => d.Cod3)
                    .WithMany(p => p.SnNeumaticos)
                    .HasForeignKey(d => new { d.CodCia, d.CodProveedor })
                    .HasConstraintName("FK_SN_Neumaticos_SN_Proveedores");

                entity.HasOne(d => d.Cod4)
                    .WithMany(p => p.SnNeumaticos)
                    .HasForeignKey(d => new { d.CodCia, d.CodMarca, d.CodModelo })
                    .HasConstraintName("FK_SN_Neumaticos_SN_Modelo_Neumatico");
            });

            modelBuilder.Entity<SnNeumaticosDet>(entity =>
            {
                entity.HasKey(e => new { e.NroCia, e.CodNeumatico, e.CodObra, e.FechaMov });

                entity.ToTable("SN_Neumaticos_Det");

                entity.Property(e => e.NroCia)
                    .HasColumnName("NRO_CIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodNeumatico)
                    .HasColumnName("COD_NEUMATICO")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CodObra)
                    .HasColumnName("COD_OBRA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaMov)
                    .HasColumnName("FECHA_MOV")
                    .HasColumnType("datetime");

                entity.Property(e => e.CodCondicion)
                    .IsRequired()
                    .HasColumnName("Cod_Condicion")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodDiseno)
                    .IsRequired()
                    .HasColumnName("COD_Diseno")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodEvento)
                    .IsRequired()
                    .HasColumnName("COD_Evento")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodFalla)
                    .HasColumnName("COD_FALLA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodProveedor)
                    .HasColumnName("COD_Proveedor")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Costo)
                    .HasColumnName("COSTO")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CostoPromedio)
                    .HasColumnName("COSTO_PROMEDIO")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Horometro)
                    .HasColumnName("HOROMETRO")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Idcarga)
                    .HasColumnName("IDCARGA")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Kilometraje)
                    .HasColumnName("KILOMETRAJE")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Linecarga).HasColumnName("LINECARGA");

                entity.Property(e => e.Notas)
                    .HasColumnName("NOTAS")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Posicion)
                    .HasColumnName("POSICION")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Presion)
                    .HasColumnName("PRESION")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Rem1).HasColumnName("REM1");

                entity.Property(e => e.Rem2).HasColumnName("REM2");

                entity.Property(e => e.Rem3).HasColumnName("REM3");

                entity.Property(e => e.RemanenteProm)
                    .HasColumnName("REMANENTE_PROM")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ubicacion)
                    .HasColumnName("UBICACION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SnObraNeumatico>(entity =>
            {
                entity.HasKey(e => new { e.CodCia, e.CodObra });

                entity.ToTable("SN_Obra_Neumatico");

                entity.Property(e => e.CodCia)
                    .HasColumnName("COD_CIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodObra)
                    .HasColumnName("COD_OBRA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Breve)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Notas)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodCiaNavigation)
                    .WithMany(p => p.SnObraNeumatico)
                    .HasForeignKey(d => d.CodCia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_Obra_Neumatico_SN_Cia_Neumatico");
            });

            modelBuilder.Entity<SnParametrosNeuma>(entity =>
            {
                entity.HasKey(e => new { e.CodCia, e.CodObra, e.CodParametro });

                entity.ToTable("SN_Parametros_Neuma");

                entity.Property(e => e.CodCia)
                    .HasColumnName("COD_CIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodObra)
                    .HasColumnName("COD_OBRA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodParametro)
                    .HasColumnName("COD_Parametro")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Breve)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Imagen)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notas)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ParaFin).HasColumnName("Para_Fin");

                entity.Property(e => e.ParaIni).HasColumnName("Para_Ini");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodCiaNavigation)
                    .WithMany(p => p.SnParametrosNeuma)
                    .HasForeignKey(d => d.CodCia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_Parametros_Neuma_SN_Cia_Neumatico");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.SnParametrosNeuma)
                    .HasForeignKey(d => new { d.CodCia, d.CodObra })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_Parametros_Neuma_SN_Obra_Neumatico");
            });

            modelBuilder.Entity<SnProveedores>(entity =>
            {
                entity.HasKey(e => new { e.CodCia, e.CodProveedor });

                entity.ToTable("SN_Proveedores");

                entity.Property(e => e.CodCia)
                    .HasColumnName("COD_CIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodProveedor)
                    .HasColumnName("COD_Proveedor")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Breve)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Celular)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Contacto)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Notas)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ruc)
                    .HasColumnName("RUC")
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodCiaNavigation)
                    .WithMany(p => p.SnProveedores)
                    .HasForeignKey(d => d.CodCia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_Proveedores_SN_Cia_Neumatico");
            });

            modelBuilder.Entity<SnTipoVehiculo>(entity =>
            {
                entity.HasKey(e => new { e.CodCia, e.CodTipo });

                entity.ToTable("SN_Tipo_Vehiculo");

                entity.Property(e => e.CodCia)
                    .HasColumnName("COD_CIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodTipo)
                    .HasColumnName("COD_Tipo")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Breve)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Notas)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodCiaNavigation)
                    .WithMany(p => p.SnTipoVehiculo)
                    .HasForeignKey(d => d.CodCia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_Tipo_Vehiculo_SN_Cia_Neumatico");
            });

            modelBuilder.Entity<SnVehiculo>(entity =>
            {
                entity.HasKey(e => new { e.CodCia, e.CodObra, e.CodVehiculo });

                entity.ToTable("SN_Vehiculo");

                entity.Property(e => e.CodCia)
                    .HasColumnName("COD_CIA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodObra)
                    .HasColumnName("COD_OBRA")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodVehiculo)
                    .HasColumnName("COD_Vehiculo")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Clase)
                    .HasColumnName("clase")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodConfiguracion)
                    .IsRequired()
                    .HasColumnName("Cod_Configuracion")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodMarca)
                    .IsRequired()
                    .HasColumnName("Cod_Marca")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodModelo)
                    .IsRequired()
                    .HasColumnName("Cod_Modelo")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CodTipo)
                    .IsRequired()
                    .HasColumnName("Cod_Tipo")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("('A')");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idcarga)
                    .HasColumnName("idcarga")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.IndVehiAlma)
                    .IsRequired()
                    .HasColumnName("IND_VEHI_ALMA")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Linea)
                    .HasColumnName("linea")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Linecarga).HasColumnName("linecarga");

                entity.Property(e => e.Notas)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NroSerie)
                    .IsRequired()
                    .HasColumnName("NRO_SERIE")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Placa)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Prefijo)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Propiedad)
                    .HasColumnName("propiedad")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Situacion)
                    .HasColumnName("situacion")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Variable)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.CodCiaNavigation)
                    .WithMany(p => p.SnVehiculo)
                    .HasForeignKey(d => d.CodCia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_Vehiculo_SN_Cia_Neumatico");

                entity.HasOne(d => d.CodC)
                    .WithMany(p => p.SnVehiculo)
                    .HasForeignKey(d => new { d.CodCia, d.CodConfiguracion })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_Vehiculo_SN_Configuracion");

                entity.HasOne(d => d.Cod)
                    .WithMany(p => p.SnVehiculo)
                    .HasForeignKey(d => new { d.CodCia, d.CodMarca })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_Vehiculo_SN_Marca_Vehiculo");

                entity.HasOne(d => d.CodNavigation)
                    .WithMany(p => p.SnVehiculo)
                    .HasForeignKey(d => new { d.CodCia, d.CodObra })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_Vehiculo_SN_Obra_Neumatico");

                entity.HasOne(d => d.Cod1)
                    .WithMany(p => p.SnVehiculo)
                    .HasForeignKey(d => new { d.CodCia, d.CodTipo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_Vehiculo_SN_Tipo_Vehiculo");

                entity.HasOne(d => d.Cod2)
                    .WithMany(p => p.SnVehiculo)
                    .HasForeignKey(d => new { d.CodCia, d.CodMarca, d.CodModelo })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SN_Vehiculo_SN_Modelo_Vehiculo");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

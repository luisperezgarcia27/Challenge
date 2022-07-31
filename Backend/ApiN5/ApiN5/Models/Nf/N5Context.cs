using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ApiN5.Models.Nf
{
    public partial class N5Context : DbContext
    {
        public N5Context()
        {
        }

        public N5Context(DbContextOptions<N5Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Permiso> Permisos { get; set; } = null!;
        public virtual DbSet<TipoPermiso> TipoPermisos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=DESKTOP-0JSI3AO;initial catalog=N5;persist security info=True;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Permiso>(entity =>
            {
                entity.Property(e => e.FechaPermiso).HasColumnType("datetime");

                entity.HasOne(d => d.TipoPermisoNavigation)
                    .WithMany(p => p.Permisos)
                    .HasForeignKey(d => d.TipoPermiso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Permisos_FK");
            });

            modelBuilder.Entity<TipoPermiso>(entity =>
            {
                entity.ToTable("TipoPermiso");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

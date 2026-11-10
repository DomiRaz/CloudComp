using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CloudComp.Models;

public partial class DebesuKompContext : DbContext
{
    public DebesuKompContext()
    {
    }

    public DebesuKompContext(DbContextOptions<DebesuKompContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Table> Tables { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Table>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__tmp_ms_x__B40CC6CDA1D28C03");

            entity.ToTable("Table");

            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.NameIndexed)
                .HasMaxLength(200)
                .HasColumnName("Name_Indexed");
            entity.Property(e => e.NameNoIndex)
                .HasMaxLength(200)
                .HasColumnName("Name_NoIndex");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

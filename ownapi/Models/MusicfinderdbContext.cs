using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ownapi.Models;

public partial class MusicfinderdbContext : DbContext
{
    public MusicfinderdbContext()
    {
    }

    public MusicfinderdbContext(DbContextOptions<MusicfinderdbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Musicfinder> Musicfinders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    
}
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Musicfinder>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__musicfin__3214EC2778A79768");

            entity.ToTable("musicfinder");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Age)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Albums)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Artist)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Lyrics)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Years)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

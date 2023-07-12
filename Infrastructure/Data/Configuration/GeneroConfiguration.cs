
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class GeneroConfiguration : IEntityTypeConfiguration<Genero>
{
    public void Configure(EntityTypeBuilder<Genero> builder)
    {
        builder.ToTable("genero");

        builder.Property(p=>p.id)
        .IsRequired();

        builder.Property(p=>p.nombre)
        .HasMaxLength(20)
        .IsRequired();

        builder.Property(p=>p.abreviatura)
        .HasMaxLength(20)
        .IsRequired();
    }
}
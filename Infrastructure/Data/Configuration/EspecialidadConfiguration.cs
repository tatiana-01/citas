using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class EspecialidadConfiguration : IEntityTypeConfiguration<Especialidad>
{
    public void Configure(EntityTypeBuilder<Especialidad> builder)
    {
        builder.ToTable("especialidad");

        builder.Property(p=>p.id)
        .IsRequired();

        builder.Property(p=>p.nombre)
        .HasMaxLength(20)
        .IsRequired();
    }
}
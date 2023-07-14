using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class ConsultorioConfiguration : IEntityTypeConfiguration<Consultorio>
{
    public void Configure(EntityTypeBuilder<Consultorio> builder)
    {
        builder.ToTable("consultorio");

        builder.Property(p=>p.id)
        .IsRequired()
        .ValueGeneratedNever();

        builder.Property(p=>p.nombre)
        .HasMaxLength(50)
        .IsRequired();
    }
}
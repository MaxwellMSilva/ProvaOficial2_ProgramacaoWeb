using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Contexto.Maps
{
    public class VeiculoMap : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.ToTable("Veiculos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Veiculo_Marca).IsRequired().HasColumnType("varchar(100)");
            builder.Property(x => x.Veiculo_Modelo).IsRequired().HasColumnType("varchar(100)");
            builder.Property(x => x.Veiculo_Ano).IsRequired().HasColumnType("varchar(100)");
            builder.Property(x => x.Veiculo_Quilometragem).IsRequired().HasColumnType("varchar(100)");
        }
    }
}

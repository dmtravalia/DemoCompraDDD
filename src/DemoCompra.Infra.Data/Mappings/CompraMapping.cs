using DemoCompra.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DemoCompra.Infra.Data.Mappings
{
    public class CompraMapping : IEntityTypeConfiguration<Compra>
    {
        public void Configure(EntityTypeBuilder<Compra> builder)
        {
            builder.HasKey(v => v.Id);

            builder.Property(v => v.Quantidade)
                .IsRequired()
                .HasColumnType("int");

            builder.Property(v => v.Descricao)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(c => c.DataCadastro)
                .IsRequired()
                .HasColumnType("datetime");

            builder.Property(c => c.DataAtualizacao)
                .IsRequired()
                .HasColumnType("datetime");

            builder.ToTable("Compra");
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGP_Certificado.Models;

namespace SGP_Certificado
{
    public class TurmaMap : IEntityTypeConfiguration<TurmaModel>
    {
        public void Configure(EntityTypeBuilder<TurmaModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome_Curso).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Nome_Professor).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Cidade).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Empresa).IsRequired().HasMaxLength(150);

        }

    }
}

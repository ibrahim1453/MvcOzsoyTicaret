using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OzsoyTicaret.WebUI.Models.Mapping
{
    public class MusteriAdreMap : EntityTypeConfiguration<MusteriAdre>
    {
        public MusteriAdreMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Adres)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Adi)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("MusteriAdres");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.MusteriId).HasColumnName("MusteriId");
            this.Property(t => t.Adres).HasColumnName("Adres");
            this.Property(t => t.Adi).HasColumnName("Adi");

            // Relationships
            this.HasRequired(t => t.Musteri)
                .WithMany(t => t.MusteriAdres)
                .HasForeignKey(d => d.MusteriId);

        }
    }
}

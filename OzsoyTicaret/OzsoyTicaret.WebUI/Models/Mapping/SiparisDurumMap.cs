using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;

namespace OzsoyTicaret.WebUI.Models.Mapping
{
    public class SiparisDurumMap : EntityTypeConfiguration<SiparisDurum>
    {
        public SiparisDurumMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Adi)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Aciklam)
                .HasMaxLength(500);

            // Table & Column Mappings
            this.ToTable("SiparisDurum");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.Adi).HasColumnName("Adi");
            this.Property(t => t.Aciklam).HasColumnName("Aciklam");
        }
    }
}

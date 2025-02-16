using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoryDb.Model.Entities.Archetype;

namespace StoryDb.Model.Data.Configurations.Relationships.Archetype
{
    public class CharacteristicConfiguration : IEntityTypeConfiguration<Characteristic>
    {
        public void Configure(EntityTypeBuilder<Characteristic> builder)
        {
            builder.HasKey(ca => ca.Id);

            builder
                .HasMany(ca => ca.ArchetypeIs)
                .WithMany(a => a.Characteristics);

            builder
                .HasMany(ca => ca.Characteristic_Characters)
                .WithOne(cc => cc.Characteristic)
                .HasForeignKey(cc => cc.Characteristic_ID);
        }
    }
}

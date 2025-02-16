using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoryDb.Model.Entities.Archetype;

namespace StoryDb.Model.Data.Configurations.Relationships.Archetype
{
    public class ArchetypeConfiguration : IEntityTypeConfiguration<ArchetypeI>
    {
        public void Configure(EntityTypeBuilder<ArchetypeI> builder)
        {
            builder.HasKey(a => a.Id);

            builder
                .HasMany(a => a.CharacterIs)
                .WithMany(c => c.ArchetypeIs);

            builder
                .HasMany(a => a.Characteristics)
                .WithMany(ca => ca.ArchetypeIs);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoryDb.Model.Entities.Archetype;

namespace StoryDb.Model.Data.Configurations.Relationships.Archetype
{
    public class Characteristic_CharacterConfiguration : IEntityTypeConfiguration<Characteristic_Character>
    {
        public void Configure(EntityTypeBuilder<Characteristic_Character> builder)
        {
            builder.HasKey(cc => cc.Id);

            builder
                .HasOne(cc => cc.CharacterI)
                .WithMany(c => c.Characteristic_Characters)
                .HasForeignKey(c => c.Character_ID);

            builder
                .HasOne(cc => cc.Characteristic)
                .WithMany(ca => ca.Characteristic_Characters)
                .HasForeignKey();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoryDb.Model.Entities.Character;

namespace StoryDb.Model.Data.Configurations.Relationships.Character
{
    public class Characteristic_UConfiguration : IEntityTypeConfiguration<Characteristic_U>
    {
        public void Configure(EntityTypeBuilder<Characteristic_U> builder)
        {
            builder.HasKey(cu => cu.Id);

            builder
                .HasMany(cu => cu.CharacterIs)
                .WithMany(c => c.Characteristic_Us);

            builder
                .HasOne(cu => cu.Characteristic_U_Type)
                .WithMany(cut => cut.Characteristic_Us)
                .HasForeignKey(cu => cu.Type_ID);

        }
    }
}

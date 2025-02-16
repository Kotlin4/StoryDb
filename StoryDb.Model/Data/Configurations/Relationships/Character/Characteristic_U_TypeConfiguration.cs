using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoryDb.Model.Entities.Character;

namespace StoryDb.Model.Data.Configurations.Relationships.Character
{
    public class Characteristic_U_TypeConfiguration : IEntityTypeConfiguration<Characteristic_U_Type>
    {
        public void Configure(EntityTypeBuilder<Characteristic_U_Type> builder)
        {
            builder.HasKey(cut => cut.Id);

            builder
                .HasMany(cut => cut.Characteristic_Us)
                .WithOne(cu => cu.Characteristic_U_Type)
                .HasForeignKey(cu => cu.Type_ID);
                
            
        }
    }
}

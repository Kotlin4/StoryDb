using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoryDb.Model.Entities.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Data.Configurations.Relationships.Character
{
    public class CharacterConfiguration : IEntityTypeConfiguration<CharacterI>
    {
        public void Configure(EntityTypeBuilder<CharacterI> builder)
        {
            builder.HasKey(c => c.Id);

            builder
                .HasMany(c => c.ArchetypeIs)
                .WithMany(a => a.CharacterIs);

            builder
                .HasMany(c => c.Characteristic_Us)
                .WithMany(cu => cu.CharacterIs);

            builder
                .HasMany(c => c.Characteristic_Characters)
                .WithOne(cc => cc.CharacterI)
                .HasForeignKey(cc => cc.Character_ID);

        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoryDb.Model.Entities.Archetype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Data.Configurations.Relationships
{
    public class CharacterArchetypeConfiguration : IEntityTypeConfiguration<Character_Archetype>
    {
        public void Configure(EntityTypeBuilder<Character_Archetype> builder)
        {
            // Указываем, что это составной ключ (CharacterId и ArchetypeId)
            builder.HasKey(ca => new { ca.Character_ID, ca.Archetype_ID });

            // Настройка связи с Character
            builder.HasOne(ca => ca.Character)
                .WithMany(c => c.Character_Archetype)
                .HasForeignKey(ca => ca.Character_ID);

            // Настройка связи с Archetype
            builder.HasOne(ca => ca.Archetype)
                .WithMany(a => a.Character_Archetype)
                .HasForeignKey(ca => ca.Archetype_ID);
        }
    }
}

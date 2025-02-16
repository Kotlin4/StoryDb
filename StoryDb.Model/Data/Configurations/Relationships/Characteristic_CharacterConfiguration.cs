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
    internal class Characteristic_CharacterConfiguration : IEntityTypeConfiguration<Characteristic_Character>
    {
        public void Configure(EntityTypeBuilder<Characteristic_Character> builder)
        {
            // Указываем, что это составной ключ (Characteristic_ID и Character_ID)
            builder.HasKey(ca => new { ca.Characteristic_ID, ca.Character_ID });

            // Настройка связи с Characteristic
            builder.HasOne(ca => ca.Characteristic)
                .WithMany(c => c.Characteristic_Characters)
                .HasForeignKey(ca => ca.Characteristic_ID);

            // Настройка связи с Character
            builder.HasOne(ca => ca.Character)
                .WithMany(a => a.Character_Characteristic)
                .HasForeignKey(ca => ca.Character_ID);
        }
    }
}

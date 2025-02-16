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
    internal class Characteristic_ArchetypeConfiguration : IEntityTypeConfiguration<Characteristic_Archetype>
    {
        public void Configure(EntityTypeBuilder<Characteristic_Archetype> builder)
        {
            // Указываем, что это составной ключ (Archetype_ID и Characteristic_ID)
            builder.HasKey(ca => new { ca.Archetype_ID, ca.Characteristic_ID });

            // Настройка связи с Archetype
            builder.HasOne(ca => ca.Archetype)
                .WithMany(c => c.Characteristic_Archetypes)
                .HasForeignKey(c => c.Archetype_ID);

            // Настройка связи с Characteristic
            builder.HasOne(ca => ca.Characteristic)
                .WithMany(a => a.Characteristic_Archetypes)
                .HasForeignKey(ca => ca.Characteristic_ID);
        }
    }
}

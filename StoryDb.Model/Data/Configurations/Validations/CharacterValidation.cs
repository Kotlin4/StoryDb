using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoryDb.Model.Entities.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Data.Configurations.Validations
{
    public class CharacterValidation : IEntityTypeConfiguration<CharacterI>
    {
        public void Configure(EntityTypeBuilder<CharacterI> builder)
        {
            throw new NotImplementedException();
        }
    }
}

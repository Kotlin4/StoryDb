using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Data.Ability
{
    public class Character_Ability
    {
        public Guid Id { get; set; }
        public int Character_ID { get; set; }
        public int Ability_ID { get; set; }
    }
}

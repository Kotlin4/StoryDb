using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Entities.Ability
{
    // Класс промехуточной таблицы присвоения способности Архетипу
    public class Archetype_Ability
    {
        public Guid Id { get; set; }
        public int Archetype_ID { get; set; }
        public int Ability_ID { get; set; }
    }
}

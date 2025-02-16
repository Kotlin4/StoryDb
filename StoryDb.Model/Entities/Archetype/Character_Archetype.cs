using StoryDb.Model.Entities.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Entities.Archetype
{
    // Класс промежуточной таблицы присвоения персонажу архетипа
    public class Character_Archetype
    {
        public Guid ID { get; set; }
        public int Character_ID { get; set; }
        public int Archetype_ID { get; set; }

        // Навигационное свойство для связи с Character
        public StoryDb.Model.Entities.Character.Character Character { get; set; }

        // Навигационное свойство для связи с Archetype
        public Archetype Archetype { get; set; }

    }
}

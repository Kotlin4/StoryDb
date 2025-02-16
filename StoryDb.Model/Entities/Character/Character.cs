using StoryDb.Model.Entities.Ability;
using StoryDb.Model.Entities.Archetype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Entities.Character
{
    // Класс таблицы персонажей
    public class Character
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Description { get; set; } = string.Empty;

        // Навигационное свойство для связи с Character_Archetype
        public ICollection<Character_Archetype> Character_Archetype { get; set; } = new List<Character_Archetype>();

        // Навигационное свойство для связи с Character_Archetype
        public ICollection<Characteristic_Character> Character_Characteristic { get; set; } = new List<Characteristic_Character>();
    }
}


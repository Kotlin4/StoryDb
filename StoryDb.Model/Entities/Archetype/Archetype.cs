using StoryDb.Model.Entities.Archetype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Entities.Archetype
{
    // Класс таблицы Архетипов
    public class Archetype
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int PARENT_ID { get; set; }

        // Навигационное свойство для связи с Character_Archetype
        public ICollection<Character_Archetype> Character_Archetype { get; set; } = new List<Character_Archetype>();

        // Навигационное свойство для связи с Characteristic_Archetype
        public ICollection<Characteristic_Archetype> Characteristic_Archetypes { get; set; } = new List<Characteristic_Archetype>();
    }
}


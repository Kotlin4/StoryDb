using StoryDb.Model.Entities.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Entities.Archetype
{
    // Класс таблицы Архетипов
    public class ArchetypeI
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int PARENT_ID { get; set; }

        // Навигационное свойство для связи с Character_Archetype
        public List<CharacterI> CharacterIs { get; set; } = [];

        // Навигационное свойство для связи с Characteristic
        public List<Characteristic> Characteristics { get; set; } = [];
    }
}


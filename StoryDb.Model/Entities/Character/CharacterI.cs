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
    public class CharacterI
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Description { get; set; } = string.Empty;


        // Навигационное свойство для связи с Characteristic_U
        public List<Characteristic_U> Characteristic_Us { get; set; } = [];

        // Навигационное свойство для связи с ArchetypeI
        public List<ArchetypeI> ArchetypeIs { get; set; } = [];

        // Навигационное свойство для связи с Characteristic
        public List<Characteristic_Character> Characteristic_Characters { get; set; } = [];
    }
}


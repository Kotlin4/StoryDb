using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Entities.Archetype
{
    // Класс таблицы характеристик Архетипа
    public class Characteristic
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Min {  get; set; }
        public int Max { get; set; }
        public int Default { get; set; }

        // Навигационное свойство для связи с Characteristic_Archetype
        public ICollection<Characteristic_Archetype> Characteristic_Archetypes { get; set; } = new List<Characteristic_Archetype>();

        // Навигационное свойство для связи с Characteristic_Character
        public ICollection<Characteristic_Character> Characteristic_Characters { get; set;} = new List<Characteristic_Character>();
    }
}

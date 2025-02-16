using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Entities.Character
{
    public class Characteristic_U
    {
        // Класс таблицы характеристик персонажа
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Type_ID { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int Default { get; set; }

        // Навигационное свойство для связи с Characteristic_U_Type
        public Characteristic_U_Type? Characteristic_U_Type { get; set; }

        // Навигационное свойство для связи с CharacterI
        public List<CharacterI> CharacterIs { get; set; } = [];

    }

}

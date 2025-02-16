using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Entities.Archetype
{
    // Класс промежуточной таблицы присвоения характеристики Архетипу
    public class Characteristic_Archetype
    {
        public Guid Id { get; set; }
        public int Archetype_ID { get; set; }
        public int Characteristic_ID { get; set; }

        // Навигационное свойство для связи с Archetype
        public Archetype Archetype { get; set; }

        // Навигационное свойство для связи с Characteristic
        public Characteristic Characteristic { get; set; }

    }
}

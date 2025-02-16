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

    }
}

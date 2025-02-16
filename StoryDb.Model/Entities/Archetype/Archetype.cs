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
    }
}


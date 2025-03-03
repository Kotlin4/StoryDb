﻿using StoryDb.Model.Data.Configurations.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Entities.Archetype
{
    // Класс таблицы характеристик Архетипа
    public class Characteristic : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Min {  get; set; }
        public int Max { get; set; }
        public int Default { get; set; }

        // Навигационное свойство для связи с Characteristic_Archetype
        public List<ArchetypeI> ArchetypeIs { get; set; } = [];

        // Навигационное свойство для связи с Characteristic_Character
        public List<Characteristic_Character> Characteristic_Characters { get; set; } = [];
    }
}

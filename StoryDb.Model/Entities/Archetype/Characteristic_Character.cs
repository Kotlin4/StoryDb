﻿using StoryDb.Model.Data.Configurations.Tags;
using StoryDb.Model.Entities.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Entities.Archetype
{
    // Класс промежуточной таблицы присвоения значения характеристик персонажу с архетипом
    public class Characteristic_Character : IEntity
    {
        public Guid Id { get; set; }
        public int Characteristic_ID { get; set; }
        public int Character_ID { get; set; }
        public int Value { get; set; }

        // Навигационное свойство для связи с Characteristic
        public Characteristic? Characteristic { get; set; }

        // Навигационное свойство для связи с Character
        public CharacterI? CharacterI { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Data.Archetype
{
    public class Characteristic_Character
    {
        public Guid Id { get; set; }
        public int Characteristic_ID { get; set; }
        public int Character_ID { get; set; }
        public int Value { get; set; }
    }
}

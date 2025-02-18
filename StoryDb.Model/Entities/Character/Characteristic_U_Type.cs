using StoryDb.Model.Data.Configurations.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Entities.Character
{
    public class Characteristic_U_Type : IEntity
    {
        // Класс таблицы типов характеристик персонажа
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        // Навигационное свойство для связи с Characteristic_U
        public List<Characteristic_U> Characteristic_Us { get; set; } = [];
    }
}

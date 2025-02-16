using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Entities.Character
{
    // Класс промежуточной таблицы для присвоения характеристик персонажу
    public class CharacteristicU_Character
    {
        public Guid Id { get; set; }
        public int CharacteristicU_ID { get; set; }
        public int Character_ID { get; set; }
    }
}

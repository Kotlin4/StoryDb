using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Entities.Location
{
    // Класс таблицы Климата на локации
    public class Сlimate
    {
        public Guid Id { get; set; }
        public int Location_ID { get; set; }
        public int Сlimate_type_ID { get; set; }
    }
}

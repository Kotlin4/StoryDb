using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Entities.Organization
{
    // Класс таблицы Членства Персонажей в Организациях
    public class Membership
    {
        public Guid Id { get; set; }
        public int Character_ID { get; set; }
        public int Organization_ID { get; set; }
        public int Fraction_ID { get; set; }
        public int Role_ID { get; set; }
        public int Division_ID { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Data.Item
{
    public class Ability_Item
    {
        public Guid Id { get; set; }
        public int Ability_ID { get; set; }
        public int Item_ID { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Data.Item
{
    public class Ownership_Item
    {
        public Guid Id { get; set; }
        public int Item_ID { get; set; }
        public enum Owner_type { }
        public int Owner_ID { get; set; }
        public int Value { get; set; }
    }
}

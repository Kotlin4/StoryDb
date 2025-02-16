using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Data.Archetype
{
    public class Characteristic
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int Min {  get; set; }
        public int Max { get; set; }
        public int Default { get; set; }
    }
}

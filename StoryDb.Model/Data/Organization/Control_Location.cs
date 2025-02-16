using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryDb.Model.Data.Organization
{
    public class Control_Location
    {
        public Guid Id { get; set; }
        public int Organization_ID { get; set; }
        public int Location_ID { get; set; }
        public enum Control_Type { }
    }
}

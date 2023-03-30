using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class EventRequest
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int InviterPhone { get; set; }
        public int MyProperty { get; set; }
    }
}

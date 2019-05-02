using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unicef.Models
{
    public class Query
    {
        public long QueryId { get; set; }
        public Form Form { get; set; }
        public Quiz Quiz { get; set; }
    }
}

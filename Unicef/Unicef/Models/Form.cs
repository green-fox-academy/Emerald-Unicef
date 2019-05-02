using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unicef.Models
{
    public class Form : ISheet
    {
        public List<IQuestion> Questions { get; set; }
        public Query Query { get; set; }
    }
}

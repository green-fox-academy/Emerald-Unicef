using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unicef.Models
{
    public class Form : ISheet
    {
        public List<Question> Questions { get; set; }
        public Query Query { get; set; }
        public Form()
        {
            this.Questions = new List<Question>();
        }
    }
}

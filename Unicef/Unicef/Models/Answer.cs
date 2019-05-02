using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unicef.Models
{
    public class Answer
    {
        public long AnswerId { get; set; }
        public string Description { get; set; }
        public bool Value { get; set; }
        public Question Question { get; set; }
    }
}

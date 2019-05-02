using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unicef.Models
{
    public class Question : IQuestion
    {
        public long QuestionId { get; set; }
        public string Description { get; set; }
        public List<Answer> Answers { get; set; }
        public ISheet Sheet { get; set; }
    }
}

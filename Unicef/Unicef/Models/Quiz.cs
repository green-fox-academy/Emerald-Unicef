using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unicef.Models
{
    public class Quiz : ISheet
    {
        public long QuizId { get; set; }
        public ICollection<IQuestion> Questions { get; set; }
        public Query Query { get; set; }
    }
}

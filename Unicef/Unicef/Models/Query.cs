using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unicef.Models
{
    public class Query
    {
        public long QueryId { get; set; }
        public Form Form
        {
            get { return Form; }
            set
            {
                if (Quiz == null)
                {
                    Form = value;
                }
            }
        }

        public Quiz Quiz
        {
            get { return Quiz; }
            set
            {
                if (Form == null)
                {
                    Quiz = value;
                }
            }
        }
    }
}

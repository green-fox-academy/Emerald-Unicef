﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unicef.Models
{
    public class Question
    {
        public long QuestionId { get; set; }
        public string Description { get; set; }
        public List<Answer> Answers { get; set; }
        
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

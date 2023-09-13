﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.Data
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int ExamId { get; set; }
        public Exam Exams { get; set; }
        public ICollection<Choise> Choices { get; set; }
    }
}

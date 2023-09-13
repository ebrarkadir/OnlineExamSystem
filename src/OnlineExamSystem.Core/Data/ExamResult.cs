using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.Data
{
    public class ExamResult
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public int ExamId { get; set; }
        public Exam Exams { get; set; }
        public int StudentId { get; set; }
        public Student Students { get; set; }
    }
}

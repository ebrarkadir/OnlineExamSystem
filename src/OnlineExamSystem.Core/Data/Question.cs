using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.Data
{
    public class Question :IDataEntity
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public ICollection<Choise> Choices { get; set; }
    }

    /// formData.append("Text",textBoxQuestions);
}

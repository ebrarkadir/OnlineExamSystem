using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.Dtos
{
    public class QuestionDto
    {
        public string Text { get; set; }
        public ICollection<ChoiseDto> Choices { get; set; }
    }
}

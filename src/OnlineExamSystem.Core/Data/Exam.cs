using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.Data
{
    public class Exam
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int TeacherId { get; set; }
        public ICollection<Choise> Choices { get; set; }
    }
}

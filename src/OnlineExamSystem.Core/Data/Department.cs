using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.Data
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Teacher> Teachers { get; set; }
        public ICollection<Student> Students { get; set; }
        public List<Exam> Exams { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public ICollection<ExamResult> ExamResults { get; set; }
    }
}

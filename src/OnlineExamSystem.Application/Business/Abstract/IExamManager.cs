using OnlineExamSystem.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.Business.Abstract
{
    public interface IExamManager
    {
        public void AddExam(ExamDto examDto);
    }
}

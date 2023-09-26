using OnlineExamSystem.Data;
using OnlineExamSystem.EntityFrameworkCore.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.Business
{
    public class ExamsManager
    {

        IExamDal _examDal;
        public ExamsManager(IExamDal examDal)
        {
            _examDal = examDal;   
        }
        public void createExam(List<Question> Questions)
        {
            // if business rule is success
            

        }
    }
}

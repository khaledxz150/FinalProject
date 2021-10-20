using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Repository
{
    public interface IExamRepository
    {
        public List<Exam> ReturnExam(int queryCode);
        public bool InsertExam(Exam exam);
        public bool UpdateExam(Exam exam);
        public bool DeleteExam(int examId);
    }
}

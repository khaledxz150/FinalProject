using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Services
{
    public interface IExamOptionService
    {
        public List<ExamOption> ReturnExamOption(int queryCode);
        public bool InsertExamOption(ExamOption examOption);
        public bool UpdateExamOption(ExamOption examOption);
        public bool DeleteExamOption(int optionId);
    }
}

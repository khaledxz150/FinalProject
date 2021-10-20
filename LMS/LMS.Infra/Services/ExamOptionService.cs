using LMS.Core.Repository;
using LMS.Core.Services;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infra.Services
{
    public class ExamOptionService: IExamOptionService
    {
        private readonly IExamOptionRepository examOptionRepository;

        public ExamOptionService(IExamOptionRepository examOptionRepository)
        {
            this.examOptionRepository = examOptionRepository;
        }

        public bool DeleteExamOption(int optionId)
        {
            return examOptionRepository.DeleteExamOption(optionId);
        }

        public bool InsertExamOption(ExamOption examOption)
        {
            return examOptionRepository.InsertExamOption(examOption);
        }

        public List<ExamOption> ReturnExamOption(int queryCode)
        {
            return examOptionRepository.ReturnExamOption(queryCode);
        }

        public bool UpdateExamOption(ExamOption examOption)
        {
            return examOptionRepository.UpdateExamOption(examOption);
        }
    }
}

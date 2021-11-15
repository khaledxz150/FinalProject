using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Data
{
    public class Certificate
    {
        public int CertificateID { get; set; }
        public int TraineeId { get; set; }
        public string CertificatePath {  get; set; }
        public bool IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public string CreatedBy { get; set; }
        public virtual Trainee Trainee { get; set; }
    }
}

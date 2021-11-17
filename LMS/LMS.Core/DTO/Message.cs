using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Data
{
   public class Message
    {  
        public int userId { get; set; }
        public string traineeName { get; set; }
        public string message { get; set; }
        public DateTime date { get; set; }
    }
}

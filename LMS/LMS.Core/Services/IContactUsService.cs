using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Services
{
    public interface IContactUsService
    {
        public List<ContactUs> ReturnMessage(int queryCode);
        public bool InsertMessage(ContactUs contactUs);
        public bool UpdateMessage(ContactUs contactUs);
        public bool DeleteMessage(int messageId);



        public Testimonial AddTestMonial(Testimonial testimonial);
        public List<Testimonial> ReturnAllTestMonial();

    }
}

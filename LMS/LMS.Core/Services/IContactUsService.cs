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
        // Testimonails 
        public bool InsertTestimonials(Testimonial testimonial);
        public bool UpdateTestimonial(Testimonial testimonial);
        public bool DeleteTestimonial(int testimonialId);
    }
}

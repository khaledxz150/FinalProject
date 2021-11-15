using LMS.Core.DTO;
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
    public class ContactUsService: IContactUsService
    {
        private readonly IContactUsRepository contactUsRepository;

        public ContactUsService(IContactUsRepository contactUsRepository)
        {
            this.contactUsRepository = contactUsRepository;
        }

        public bool DeleteMessage(int messageId)
        {
            return contactUsRepository.DeleteMessage(messageId);
        }

        public bool InsertMessage(ContactUs contactUs)
        {
            return contactUsRepository.InsertMessage(contactUs);
        }

        public List<ContactUs> ReturnMessage(int queryCode)
        {
            return contactUsRepository.ReturnMessage(queryCode);
        }

        public bool UpdateMessage(ContactUs contactUs)
        {
            return contactUsRepository.UpdateMessage(contactUs);
        }

        // Testimonails 
        public bool InsertTestimonials(Testimonial testimonial)
        {
            return contactUsRepository.InsertTestimonials   (testimonial);
        }
        public bool UpdateTestimonial(Testimonial testimonial)
        {
            return contactUsRepository.UpdateTestimonial(testimonial);
        }
        public bool DeleteTestimonial(int testimonialId)
        {
            return contactUsRepository.DeleteTestimonial(testimonialId);
        }

        public List<UserTestimonailsDTO> GetUserTestimonails(int queryID)
        {
            return contactUsRepository.GetUserTestimonails  (queryID);
        }
    }
}

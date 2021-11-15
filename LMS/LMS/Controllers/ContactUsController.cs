using LMS.Core.DTO;
using LMS.Core.Services;
using LMS.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactUsController : ControllerBase
    {
        private readonly IContactUsService contactUsService;

        public ContactUsController(IContactUsService contactUsService)
        {
            this.contactUsService = contactUsService;

        }


        [HttpPost]
        [Route("[action]/{queryCode}")]
        public List<ContactUs> ReturnMessage(int queryCode)
        {
            return contactUsService.ReturnMessage(queryCode);
        }

        [HttpPost]
        [Route("[action]")]
        public bool InsertMessage([FromBody] ContactUs contactUs)
        {
            return contactUsService.InsertMessage(contactUs);
        }

        [HttpPut]
        [Route("[action]")]
        public bool UpdateMessage([FromBody] ContactUs contactUs)
        {
            return contactUsService.UpdateMessage(contactUs);
        }

        [HttpPut]
        [Route("[action]/{messageId}")]
        public bool DeleteMessage(int messageId)
        {
            return contactUsService.DeleteMessage(messageId);
        }

        // Testimonails 
        [HttpPost]
        [Route("[action]")]
        public bool InsertTestimonials(Testimonial testimonial)
        {
            return contactUsService.InsertTestimonials(testimonial);
        }
        [HttpPut]
        [Route("[action]")]
        public bool UpdateTestimonial(Testimonial testimonial)
        {
            return contactUsService.UpdateTestimonial   (testimonial);
        }

        [HttpPut]
        [Route("[action]/{testimonialId}")]
        public bool DeleteTestimonial(int testimonialId)
        {
            return contactUsService.DeleteTestimonial(testimonialId);
        }
        [HttpPost]
        [Route("[action]/{queryID}")]
        public List<UserTestimonailsDTO> GetUserTestimonails(int queryID)
        {
            return contactUsService.GetUserTestimonails(queryID);
        }
    }
}

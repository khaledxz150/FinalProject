using LMS.Core.Data;
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
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;

        //Edit Api By Jasser Will start After Commit This Changes 
        //Commit At 12:41 pm In 15/11/2021

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;

        }

        //Cart 

        [HttpPost]
        [Route("[action]")]
        public List<Cart> ReturnCart([FromQuery] int queryCode, [FromQuery] int trineeId)
        {
            return customerService.ReturnCart(queryCode, trineeId);
        }


        [HttpPost]
        [Route("[action]/{queryCode}")]
        public List<Trainee> ReturnTrainee(int queryCode)
        {
            return customerService.ReturnTrainee(queryCode);
        }


        [HttpPost]
        [Route("[action]")]
        public bool InsertCart([FromBody] Cart cart)
        {
            return customerService.InsertCart(cart);
        }


        [HttpPut]
        [Route("[action]/{cartId}")]
        public bool DeleteCart(int cartId)
        {
            return customerService.DeleteCart(cartId);
        }


        //CartItem

        [HttpPost]
        [Route("[action]")]
        public bool InsertCartItem([FromBody] CartItem cartItem)
        {
            return customerService.InsertCartItem(cartItem);
        }


        [HttpDelete]
        [Route("[action]")]
        public bool DeleteCartItem([FromQuery]int cartId)
        {
            return customerService.DeleteCartItem(cartId);
        }


        //Checkout

        [HttpGet]
        [Route("[action]")]
        public List<Checkout> ReturnCheckout()
        {
            return customerService.ReturnCheckout();
        }

        [HttpPost]
        [Route("[action]/{traineeId}")]
        public List<EnrollmentDTO> ReturnEnrollmentCourses(int traineeId)
        {
            return customerService.ReturnEnrollmentCourses(traineeId);
        }
        [HttpPost]
        [Route("[action]/{traineeId}")]
        public List<MySectionsDTO> ReturnSection(int traineeId)
        {
            return customerService.ReturnSection(traineeId);
        }
        [HttpPost]
        [Route("[action]/{traineeId}")]
        public List<LiveCourseDTO> ReturnLiveCourses(int traineeId)
        {
            return customerService.ReturnLiveCourses(traineeId);
        }
        [HttpPost]
        [Route("[action]")]
        public bool InsertCheckout([FromBody] Checkout checkout)
        {
            return customerService.InsertCheckout(checkout);
        }

        //WishList
        [HttpPost]
        [Route("[action]/{traineeId}")]
        public List<WishList> ReturnWishList(int traineeId)
        {
            return customerService.ReturnWishList(traineeId);
        }
        [HttpPost]
        [Route("[action]")]
        public bool InsertWishList([FromBody] WishList wishList)
        {
            return customerService.InsertWishList(wishList);
        }
        [HttpPut]
        [Route("[action]/{wishListId}")]
        public bool DeleteWishList(int wishListId)
        {
            return customerService.DeleteWishList(wishListId);
        }

        //WithListItem
        [HttpPost]
        [Route("[action]")]
        public bool InsertWishListItem([FromBody] WishListItem wishListItem)
        {
            return customerService.InsertWishListItem(wishListItem);
        }
        [HttpDelete]
        [Route("[action]")]
        public bool DeleteWishListItem([FromQuery]int wishListId, [FromQuery] int courseId)
        {
            return customerService.DeleteWishListItem(wishListId,courseId);
        }




        //ReturnAllCartItem

        [HttpPost]
        [Route("[action]/{traineeId}")]
        public List<CartItemDTO> ReturnAllCartItem(int traineeId)
        {
            return customerService.ReturnAllCartItem(traineeId);
        }

        //ReturnWishListItem
        [HttpPost]
        [Route("[action]/{traineeId}")]
        public List<WishListItemDTO> ReturnWishListItem(int traineeId)
        {
            return customerService.ReturnWishListItem(traineeId);
        }




        //ReturnSoldCourses
        [HttpGet]
        [Route("[action]")]
        public List<SoldCourseDTO> ReturnSoldCourses()
        {
            return customerService.ReturnSoldCourses();
        }



        //ReturnTraineeAttendance

        [HttpPost]
        [Route("[action]/{sectionId}/{lectureId}")]
        public List<TraineeAttendanceDTO> ReturnTraineeAttendance(int sectionId, int lectureId)
        {
            return customerService.ReturnTraineeAttendance(sectionId, lectureId);
        }


        //ReturnTraineeInfo
        [HttpPost]
        [Route("[action]/{traineeId}")]
        public TraineeInfoDTO ReturnTraineeInfo(int traineeId)
        {
            return customerService.ReturnTraineeInfo(traineeId);
        }

        [HttpPost]
        [Route("[action]")]
        // Add New Trainee 
        public Task<bool> InsertTrainee([FromBody] TraineeInfoDTO trainee)
        {
            return customerService.InsertTrainee(trainee);
        }

        [HttpPut]
        [Route("[action]")]
        //Update Trainee 
        public bool UpdateTrainee([FromBody] Trainee trainee)
        {
            return customerService.UpdateTrainee(trainee);
        }

        [HttpPut]
        [Route("[action]/{traineeId}")]
        //Delete Trainee
        public bool DeleteTrainee(int traineeId)
        {
            return customerService.DeleteTrainee(traineeId);
        }
        [HttpPost]
        [Route("[action]")]
        public bool InsertCertificate([FromBody] Certificate certificate)
        {
            return customerService.InsertCertificate(certificate);
        }
        [HttpPut]
        [Route("[action]/{certificateId}")]
        public bool DeleteCertificate(int certificateId)
        {
            return customerService.DeleteCertificate(certificateId);
        }

    }

}

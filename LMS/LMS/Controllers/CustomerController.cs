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

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;

        }

        //Cart 

        [HttpPost]
        [Route("[action]/{queryCode}/{trineeId}")]
        public List<Cart> ReturnCart(int queryCode, int trineeId)
        {
            return customerService.ReturnCart(queryCode,trineeId);
        }

        [HttpPut]
        [Route("[action]")]
        public bool InsertCart([FromBody] Cart cart)
        {
            return customerService.InsertCart(cart);
        }


        [HttpDelete]
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
        [Route("[action]/{cartItemId}")]
        public bool DeleteCartItem(int cartItemId)
        {
            return customerService.DeleteCartItem(cartItemId);
        }


        //Checkout

        [HttpGet]
        [Route("[action]")]
        public List<Checkout> ReturnCheckout()
        {
            return customerService.ReturnCheckout();
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
            return customerService.ReturnWishList( traineeId);
        }
        [HttpPost]
        [Route("[action]")]
        public bool InsertWishList([FromBody]  WishList wishList)
        {
            return customerService.InsertWishList(wishList);
        }
        [HttpDelete]
        [Route("[action]/{wishListId}")]
        public bool DeleteWishList(int wishListId)
        {
            return customerService.DeleteWishList(wishListId);
        }

        //WithListItem
        [HttpPost]
        [Route("[action]")]
        public bool InsertWishListItem([FromBody]  WishListItem wishListItem)
        {
            return customerService.InsertWishListItem(wishListItem);
        }
        [HttpDelete]
        [Route("[action]/{wishListItemId}")]
        public bool DeleteWishListItem(int wishListItemId)
        {
            return customerService.DeleteWishListItem(wishListItemId);
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

        //ReturnAllCoupon
        [HttpPost]
        [Route("[action]/{queryCode}")]
        public List<CouponDTO> ReturnAllCoupon(int queryCode)
        {
            return customerService.ReturnAllCoupon(queryCode);
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
        public List<TraineeInfoDTO> ReturnTraineeInfo(int traineeId)
        {
            return customerService.ReturnTraineeInfo(traineeId);
        }

        [HttpPost]
        [Route("[action]")]
        // Add New Trainee 
        public bool InsertTrainee([FromBody] Trainee trainee)
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



    }

}

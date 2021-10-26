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
        [Route("[action]/{queryCode}")]
        public List<Cart> ReturnCart(int queryCode)
        {
            return customerService.ReturnCart(queryCode);
        }

        [HttpPost]
        [Route("[action]")]
        public Task<Cart> AddNewCart([FromBody] Cart cart)
        {
            return customerService.AddNewCart(cart);
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
        public bool AddNewCartItem([FromBody] CartItem cartItem)
        {
            return customerService.AddNewCartItem(cartItem);
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
        [Route("[action]")]
        public List<WishList> ReturnWishList()
        {
            return customerService.ReturnWishList();
        }
        [HttpPost]
        [Route("[action]")]
        public Task<WishList> InsertWishList([FromBody]  WishList wishList)
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
    }

}

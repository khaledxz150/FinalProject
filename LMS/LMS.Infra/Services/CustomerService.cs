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
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }

        public Task<Cart> AddNewCart(Cart cart)
        {
            return customerRepository.AddNewCart(cart);
        }

        public bool AddNewCartItem(CartItem cartItem)
        {
            return customerRepository.AddNewCartItem(cartItem);
        }

        public bool DeleteCart(int cartId)
        {
            return customerRepository.DeleteCart(cartId);
        }

        public bool DeleteCartItem(int cartItemId)
        {
            return customerRepository.DeleteCartItem(cartItemId);
        }

        public bool InsertCheckout(Checkout checkout)
        {
            return customerRepository.InsertCheckout(checkout);
        }

        public List<Cart> ReturnCart(int queryCode)
        {
            return customerRepository.ReturnCart(queryCode);
        }


        public List<Checkout> ReturnCheckout()
        {
            return customerRepository.ReturnCheckout();
        }

        //WishList

        public List<WishList> ReturnWishList()
        {
            return customerRepository.ReturnWishList();
        }
        public bool InsertWishList(WishList wishList)
        {
            return customerRepository.InsertWishList(wishList);
        }
        public bool DeleteWishList(int wishListId)
        {
            return customerRepository.DeleteWishList(wishListId);
        }

        //WithListItem

        public bool InsertWishListItem(WishListItem wishListItem)
        {
            return customerRepository.InsertWishListItem(wishListItem);
        }
        public bool DeleteWishListItem(int wishListItemId)
        {
            return customerRepository.DeleteWishListItem(wishListItemId);   
        }
    }

}

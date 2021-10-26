using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Repository
{
    public interface ICustomerRepository
    {
        //Cart

        public List<Cart> ReturnCart(int queryCode);
        public Task<Cart> AddNewCart(Cart cart);
        public bool DeleteCart(int cartId);

        //CartItem

        public bool AddNewCartItem(CartItem cartItem);
        public bool DeleteCartItem(int cartItemId);

        //Checkout
        public List<Checkout> ReturnCheckout();
        public bool InsertCheckout(Checkout checkout);
        //public bool DeleteCheckout(int checkoutId);

        //WishList

        public List<WishList> ReturnWishList();
        public Task<WishList> InsertWishList(WishList wishList);
        public bool DeleteWishList(int wishListId);

        //WithListItem

        public bool InsertWishListItem(WishListItem wishListItem);
        public bool DeleteWishListItem(int wishListItemId);
    }

}

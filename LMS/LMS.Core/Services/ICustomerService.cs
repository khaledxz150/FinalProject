using LMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Services
{
    public interface ICustomerService
    {
        //Cart

        public List<Cart> ReturnCart(int queryCode);
        public Task<Cart> AddNewCart(Cart cart);
        public bool DeleteCart(int cartId);

        //CartItem

        //public List<CartItem> ReturnCartItem(int queryCode);
        public bool AddNewCartItem(CartItem cartItem);
        public bool DeleteCartItem(int cartItemId);

        //Checkout
        public List<Checkout> ReturnCheckout();
        public bool InsertCheckout(Checkout checkout);
        //public bool DeleteCheckout(int checkoutId);
    }

}

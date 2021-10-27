using Dapper;
using First.Core.Common;
using LMS.Core.Repository;
using LMS.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Infra.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private IDbContext dBContext;
        public CustomerRepository(IDbContext dBContext)
        {
            this.dBContext = dBContext;
        }

        public async Task<Cart> AddNewCart(Cart cart)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@TraineeId", cart.TraineeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = await dBContext.Connection.ExecuteAsync("AddNewCart", parameters, commandType: CommandType.StoredProcedure);
            return ReturnCart(1).OrderByDescending(x => x.CartId).FirstOrDefault();
        }

        public bool AddNewCartItem(CartItem cartItem)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@CartId", cartItem.CartId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@CourseID", cartItem.CourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("AddNewCartItem", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteCart(int cartId)
        {
            var parm = new DynamicParameters();
            parm.Add("@recordId", cartId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DisActivateCart", parm, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool DeleteCartItem(int cartItemId)
        {
            var parm = new DynamicParameters();
            parm.Add("@recordId", cartItemId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DisActivateCartItem", parm, commandType: CommandType.StoredProcedure);
            return true;
        }



        public bool InsertCheckout(Checkout checkout)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@CartId", checkout.CartId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("InsertCheckout", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Cart> ReturnCart(int queryCode)
        {
            var parm = new DynamicParameters();
            parm.Add("@Query_CODE", queryCode, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Cart> result = dBContext.Connection.Query<Cart>("ReturnCart", parm, commandType: CommandType.StoredProcedure);
            return result.ToList();

        }

        public List<Checkout> ReturnCheckout()
        {

            IEnumerable<Checkout> result = dBContext.Connection.Query<Checkout>("ReturnCheckout", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        //WishList

        public List<WishList> ReturnWishList()
        {


            IEnumerable<WishList> result = dBContext.Connection.Query<WishList>("ReturnAllWhihlist", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }
        public bool InsertWishList(WishList wishList)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@P_TraineeId",wishList.TraineeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("InsertWishlist", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteWishList(int wishListId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@P_WishListId", wishListId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteWishlist", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }

        //WithListItem

        public bool InsertWishListItem(WishListItem wishListItem)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@P_WishListId",wishListItem.WishListId , dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@P_CourseId", wishListItem.CourseId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            parameters.Add("@P_CreatedBy", wishListItem.CreatedBy, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("InsertWishlistItem", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool DeleteWishListItem(int wishListItemId)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@P_WishListItemId", wishListItemId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = dBContext.Connection.ExecuteAsync("DeleteWishlistItem", parameters, commandType: CommandType.StoredProcedure);
            return true;
        }


    }

}

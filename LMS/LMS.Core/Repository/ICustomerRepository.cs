using LMS.Core.Data;
using LMS.Core.DTO;
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

        public List<Cart> ReturnCart(int queryCode, int trineeId);
        public bool InsertCart(Cart cart);
        public bool DeleteCart(int cartId);

        //CartItem
        
        public bool InsertCartItem(CartItem cartItem);
        public bool DeleteCartItem(int cartItemId);

        //Checkout
        public List<Checkout> ReturnCheckout();
        public bool InsertCheckout(Checkout checkout);
        //public bool DeleteCheckout(int checkoutId);

        //ReturnSoldCourses
        public List<SoldCourseDTO> ReturnSoldCourses();

        //WishList

        public List<WishList> ReturnWishList(int traineeId);
        public bool InsertWishList(WishList wishList);
        public bool DeleteWishList(int wishListId);

        //WithListItem

        public bool InsertWishListItem(WishListItem wishListItem);
        public bool DeleteWishListItem(int wishListItemId);


        //ReturnAllCartItem
        public List<CartItemDTO> ReturnAllCartItem(int traineeId);


        //ReturnWishListItem
        public List<WishListItemDTO> ReturnWishListItem(int traineeId);



        //ReturnTraineeAttendance
        public List<TraineeAttendanceDTO> ReturnTraineeAttendance(int sectionId, int lectureId);

        //ReturnTraineeInfo
        public List<Trainee> ReturnAllTrainee(int queryCode);
       
        public List<TraineeInfoDTO> ReturnTraineeInfo(int traineeId);

        // Add New Trainee 
        public bool InsertTrainee(Trainee trainee);

        //Update Trainee 
        public bool UpdateTrainee(Trainee trainee);

        //Delete Trainee
        public bool DeleteTrainee(int traineeId);

        //Insert Certificate

        public bool InsertCertificate(Certificate certificate);

        public bool DeleteCertificate(int certificateId);
        //change status
        public bool ChangeTraineeStatus(Int64 trainerId);
    }

}

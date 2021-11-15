import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { CartItem } from '../models/cartitem';
import { WishItem } from '../models/wishlist';
import { CourseService } from './course.service';

@Injectable({
  providedIn: 'root'
})
export class TraineeNavbarService {

  cartItem:CartItem[]=[];
  wishList:WishItem[]=[];
  cartItemCount:number=0;
  wishListItemCount:number=0;
  totalPrice:number=0;


  constructor(private http:HttpClient,private toastr:ToastrService,courseService:CourseService) {}


  getMyCartItem2(traineeId:number){
    this.http.post('http://localhost:54921/api/Customer/ReturnAllCartItem/'+traineeId,null).
    subscribe((res:any)=>{
      this.cartItem=res;
      this.cartItemCount=res.length
      for(let item of res){
        this.totalPrice+=item.coursePrice
      }
    })
  }
  getMyWishListItem(traineeId:number){
    this.http.post('http://localhost:54921/api/Customer/ReturnWishListItem/'+traineeId,null).
    subscribe((res:any)=>{
      this.wishList=res;
      this.wishListItemCount=res.length
      console.log(res)
    })
  }
  RemoveWishListItem(wishItemId:number,courseId:number){
    this.http.
    delete('http://localhost:54921/api/Customer/DeleteWishListItem?wishListId='+wishItemId+'&courseId='+courseId)
    .subscribe((res)=>{
      console.log(res)

      if(res){
        this.toastr.warning('removed Succesfuly')
        window.location.reload()
      }


    })
  }
  RemoveCartItem(cartItemId:number){
    this.http.
    delete('http://localhost:54921/api/Customer/DeleteCartItem?cartId='+cartItemId)
    .subscribe((res)=>{
      console.log(res)
      console.log(cartItemId)
      if(res){
        this.toastr.warning('removed Succesfuly')

      }


    })
  }
}

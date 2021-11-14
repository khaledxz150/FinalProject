import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { CartItem } from '../models/cartitem';
import { WishItem } from '../models/wishlist';

@Injectable({
  providedIn: 'root'
})
export class TraineeNavbarService {

  cartItem:CartItem[]=[];
  wishList:WishItem[]=[];
  cartItemCount:number=0;
  wishListItemCount:number=0;
  totalPrice:number=0;
  constructor(private http:HttpClient,private toastr:ToastrService) {


   }
  getMyCartItem2(traineeId:number){
    console.log("StartService")
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
}

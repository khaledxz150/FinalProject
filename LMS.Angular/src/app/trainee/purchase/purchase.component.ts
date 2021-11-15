import { Component, OnInit } from '@angular/core';
import { CourseService } from 'src/app/Service/course.service';
import { PurchesService } from 'src/app/Service/purches.service';
import { TraineeNavbarService } from 'src/app/Service/trainee-navbar.service';
import { TraineeService } from 'src/app/Service/trainee.service';

@Component({
  selector: 'app-purchase',
  templateUrl: './purchase.component.html',
  styleUrls: ['./purchase.component.css',
  '../../../assets/css/default.css',
  '../../../assets/css/slick.css',
  '../../../assets/css/style.css'

  ,'../../../assets/css/animate.css'
]
})
export class PurchaseComponent implements OnInit {

  constructor(public purchesService:PurchesService,public traineeService:TraineeNavbarService
    ,public courseService:CourseService) { }

  ngOnInit(): void {
    this.purchesService.GetMyPurshes();
    this.purchesService.GetMyRefunds();
    this.traineeService.getMyCartItem2(2)
    this.traineeService.getMyWishListItem(2)
    this.courseService.GetAvailableCartId(2)
    this.courseService.GetAvailableWishListId(2)
  }

  DeleteCartItem(cartItemId:number){
    this.traineeService.RemoveCartItem(cartItemId)
  }

  DeleteWishListItem(courseId:number){
    this.traineeService.RemoveWishListItem(this.courseService.wishListId,courseId)
  }
  AddToCart(courseId:number|undefined){
    const cartItem:any={
      cartId: this.courseService.cartId,
      CourseId: courseId
    }

    this.courseService.AddCourseToCart(cartItem)
  }

}

import { Component, OnInit } from '@angular/core';
import { CourseService } from 'src/app/Service/course.service';
import { PurchesService } from 'src/app/Service/purches.service';
import { TraineeNavbarService } from 'src/app/Service/trainee-navbar.service';
import { TraineeService } from 'src/app/Service/trainee.service';

//Update Purches
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
    strikeCheckout:any = null;
  ngOnInit(): void {
    this.stripePaymentGateway();
    this.purchesService.GetMyPurshes();
    this.purchesService.GetMyRefunds(2);
    this.traineeService.getMyCartItem2(2)
    this.traineeService.getMyWishListItem(2)
    this.courseService.GetAvailableCartId(2)
    this.courseService.GetAvailableWishListId(2)
  }
  checkout(amount:any) {
    const strikeCheckout = (<any>window).StripeCheckout.configure({
      key: 'Abj3-K-gQ0Gtgdw3iHF73msqKg-uf-ZEUYKHXQNs1U3Hr3oav6uSRSvU_cbhu3Ep_ulcaW4BcwKkioIL',
      locale: 'auto',
      token: function (stripeToken: any) {
        console.log(stripeToken)
        alert('Stripe token generated!');
      }
    });
  
    strikeCheckout.open({
      name: 'RemoteStack',
      description: 'Payment widgets',
      amount: amount * 100
    });
  }
  
  stripePaymentGateway() {
    if(!window.document.getElementById('stripe-script')) {
      const scr = window.document.createElement("script");
      scr.id = "stripe-script";
      scr.type = "text/javascript";
      scr.src = "https://checkout.stripe.com/checkout.js";

      scr.onload = () => {
        this.strikeCheckout = (<any>window).StripeCheckout.configure({
          key: 'pk_test_12239293949ksdfksdjkfj1232q3jkjssdfjk',
          locale: 'auto',
          token: function (token: any) {
            console.log(token)
            alert('Payment via stripe successfull!');
          }
        });
      }
        
      window.document.body.appendChild(scr);
    }
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

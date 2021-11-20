import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthenticationService } from 'src/app/Service/authentication.service';
import { CourseService } from 'src/app/Service/course.service';
import { TraineeNavbarService } from 'src/app/Service/trainee-navbar.service';

@Component({
  selector: 'app-courses',
  templateUrl: './courses.component.html',
  styleUrls: ['./courses.component.css'
  , '../../../assets/css/default.css',
  '../../../assets/css/slick.css',
  '../../../assets/css/style.css'
  ,'../../../assets/css/animate.css']
})
export class CoursesComponent implements OnInit {


  constructor(public courseService:CourseService
    ,public trainee:TraineeNavbarService
    ,public router:Router ,public auth:AuthenticationService) { }
  loggedIn:any|undefined;
  ngOnInit(): void {
    this.courseService.GetAvailableCartId(2)
    this.courseService.getAllAvailableCourse()
    this.courseService.GetAvailableWishListId(2)
    this.loggedIn=localStorage.getItem("user")
    let traineeId=JSON.parse(this.loggedIn)
    this.loggedIn=traineeId.traineeId
    console.log(this.loggedIn)
  }
  getLink(coureId:number|undefined){
    navigator.clipboard.writeText
    ('http://localhost:4200/pages/courseInfo'+'/'+coureId).then().catch(e => console.error(e));
  }
  DisplayCourseInfo(id:number|undefined){
     this.courseService.GetSingleCourseInfoById(id)
     this.router.navigate(['pages','courseInfo',id])
  }

  AddToCart(courseId:number|undefined){
    if(this.auth.loggedIn){
      const cartItem:any={
        cartId: this.courseService.cartId,
        CourseId: courseId
      }

      this.courseService.AddCourseToCart(cartItem)
      this.trainee.getMyCartItem2

    }else{
      this.router.navigate(['auth','login'])
    }

  }
  AddToWishList(courseId:number|undefined){
    if(this.auth.loggedIn){
      const wishListItem:any={
        wishListId: this.courseService.wishListId,
        courseId: courseId,
        createdBy: "System",
      }
      this.courseService.AddCourseToWishList(wishListItem)
      this.courseService.reloadComponent()

    }else{

      this.router.navigate(['auth','login'])
    }

  }

}

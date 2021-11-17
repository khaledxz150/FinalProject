import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';
import { Coupon, Course, SoldCourse } from '../models/course';
import { CourseCard } from '../models/courseCard';
import { Topic } from '../models/topic';

@Injectable({
  providedIn: 'root'
})
export class CourseService {


  courses: Course[]=[];
  countOfCourses:number = 0;
  availableCourses:CourseCard[]=[];
  courseTopic:Topic[]=[];
  courseComment:any[]=[];
  courseSection:any[]=[];
  singleCourse:any={};
  coursesActualRating:any[]=[];
  coursesSumationOfReview:any[]=[]
  finalRate:number=0;
  summationRate:number=0;
  cartId:number=0;
  wishListId:number=0;

  constructor(private http: HttpClient,private toastr:ToastrService, private spinner:NgxSpinnerService) { }

//get course

  getCourses(){



    // debugger;
    this.spinner.show();

     this.http.post(environment.apiUrl + 'Course/ReturnAllCourses/1',1).subscribe((res:any)=>{
      debugger
      console.log(res)
      this.courses = res;
      this.countOfCourses = res.length;
      this.spinner.hide();


    },err=>{
      this.spinner.hide();
      this.toastr.warning('Something wrong');
    })
    debugger;



  }

//delete Course

  deleteCourse(courseId:number){


    // const contactUs : ContactUs = this.contactUsForm.value;

    // debugger;
     this.spinner.show();

    this.http.put(environment.apiUrl + 'Course/DeleteCourse/'+courseId,courseId).subscribe((res:any)=>{
      // debugger
      // this.toastr.success('Send Message successfully, Thank You :)');
      debugger
      console.log(res)
      this.courses = res;

      // console.log( "test",this.courses)
      window.location.reload();
      this.spinner.hide();

      this.toastr.success('Course Deleted successfully !!!');

    },err=>{
      // this.spinner.hide();
      this.toastr.error('Something Wrong, Try Again!');
    })
    debugger;
  }

//create course

  createCourse(course:any){
    debugger
    this.spinner.show();
    this.http.post(environment.apiUrl + 'Course/InsertCourse/',course).subscribe((res:any)=>{
      debugger
      this.spinner.hide();
      this.toastr.success('Course Created successfully !!!');

      window.location.reload()

    },err=>{
      this.spinner.hide();
      this.toastr.error('Something Wrong, Try Again!');
    })
  }


  //update course

  updateCourse(course:any){

     debugger;
     this.spinner.show();

    this.http.put(environment.apiUrl + 'Course/UpdateCourse',course).subscribe((res:any)=>{
      debugger
      window.location.reload();

      this.spinner.hide();

      this.toastr.success('Course Updated successfully !!!');

    },err=>{
      this.spinner.hide();
      this.toastr.error('Something Wrong, Try Again!');
    })
    debugger;
  }



  //Tags

  tag:any[]=[]
  getAllTags(){

    this.http.get(environment.apiUrl + 'Course/GetAllTags').subscribe((res:any)=>{


      this.tag = res;
    })

  }


    //Levels

    level:any[]=[]
    getAllLevels(){

      this.http.post(environment.apiUrl + 'Course/ReturnLevel/1',1).subscribe((res:any)=>{


        this.level = res;
      })

    }


    //Types

    type:any[]=[]
    getAllTypes(){

      this.http.get(environment.apiUrl + 'Course/GetAllType',).subscribe((res:any)=>{


        this.type = res;
      })

    }



    //Topics

    topic:Topic[]=[]
    getAllTopics(courseId:number){

      this.http.post(environment.apiUrl + 'Course/GetCourseTopic/'+courseId,courseId).subscribe((res:any)=>{


        this.topic = res;
      })

    }


    deleteTopic(topicId:number){

      this.spinner.show()
      this.http.put(environment.apiUrl + 'Course/DeleteTopic/'+topicId,topicId).subscribe((res:any)=>{

        this.spinner.hide();

        this.toastr.error('Topic deleted Successfully !');

      },err=>{
      this.spinner.hide();
      this.toastr.error('Something Wrong, Try Again!');
    })

    }

    createTopic(topic:any){


    debugger
    this.spinner.show()

      this.http.post(environment.apiUrl + 'Course/InsertTopic/',topic).subscribe((res:any)=>{


        window.location.reload()
        this.spinner.hide()

        this.toastr.success('Topic Created successfully !!!');

      },err=>{
        this.spinner.hide();
        this.toastr.error('Something Wrong, Try Again!');
      })

      debugger
    }

    updateTopic(topic:any){

      debugger
      this.spinner.show();
            this.http.put(environment.apiUrl + 'Course/UpdateTopic/',topic).subscribe((res:any)=>{


              this.spinner.hide();

              this.toastr.success('Topic updated successfully !!!');

              window.location.reload()
            },err=>{
              this.spinner.hide()
              this.toastr.warning('something Wrong   !!!');

            })

            debugger
    }


       //Coupon

       coupon:Coupon[]=[]


       ReturnAllCoupon(){
         debugger
         this.http.post(environment.apiUrl + 'Course/ReturnAllCoupon/'+0,0).subscribe((res:any)=>{

           debugger
           this.coupon = res;
         })

       }

       createCoupon(coupon:any){


       debugger
       this.http.post(environment.apiUrl + 'Course/InsertCoupon/',coupon).subscribe((res:any)=>{


         window.location.reload()
         this.toastr.success('coupon Created successfully !!!');

       },err=>{
         // this.spiner.hide();
         this.toastr.warning('Something Wrong, Try Again!');
       })

       debugger
       }


       ChangeCouponStatus(couponId:number){


         debugger

         this.spinner.show()
         this.http.put(environment.apiUrl + 'Course/ChangeCouponStatus/'+couponId,couponId).subscribe((res:any)=>{


           window.location.reload()
           this.spinner.hide()
           this.toastr.success('Coupon Updated successfully !!!');

         },err=>{
           this.spinner.hide();
           this.toastr.warning('Something Wrong, Try Again!');
         })

         debugger
       }

       updateCoupon(updatedCoupon:any){


         debugger
         this.spinner.show()
         this.http.put(environment.apiUrl + 'Course/UpdateCoupon/',updatedCoupon).subscribe((res:any)=>{


           window.location.reload()
           this.spinner.hide()
           this.toastr.success('Coupon Updated successfully !!!');

         },err=>{
          this.spinner.hide()
           this.toastr.error('Something Wrong, Try Again!');
         })

         debugger
       }


       getALlRefund(){

       }


       //Checkout

       soldCourse:SoldCourse[]=[]
       countOfSoldCourses = 0;
       totalSales:any = 0
       recentSoldCourses:any[] =[]
       annualSoldCourses:any[]=[]

       returnSoldCourses(){
         this.http.get(environment.apiUrl + 'Customer/ReturnSoldCourses').subscribe((res:any)=>{

           debugger
           this.soldCourse = res;
           this.annualSoldCourses = res;
          this.countOfSoldCourses = res.length;

          this.soldCourse.forEach((total) => {

           this.totalSales =this.totalSales + total.coursePrice

           // let date = new Date();
           const date=new Date();
           this.recentSoldCourses = this.soldCourse.filter(course => new Date(course.creationDate).getDate() == date.getDate())
           // console.log("Date.now.toString() = ", date)
           // console.log("Date = ", course.creationDate)


          });
          this.totalSales = (Math.round( this.totalSales * 100) / 100).toFixed(2);

         })
       }


       filterSoldCourse(year:any){
         this.soldCourse = this.annualSoldCourses.filter(course => new Date(course.creationDate).getFullYear() == year.value)
         debugger
         // this.returnSoldCourses();
         // this.soldCourse = this.annualSoldCourses.filter(course => new Date(course.creationDate).getMonth()+1 == month.value)

       }

       filterSoldCourseBetweenDate(startDate:any, endDate:any){
         this.soldCourse = this.annualSoldCourses.filter(course => new Date(course.creationDate) >= startDate.value && new Date(course.creationDate) <= endDate.value)



         console.log("startDate = ",startDate);
         console.log("endDate = ",endDate);
         debugger

         // this.returnSoldCourses();
         // this.soldCourse = this.annualSoldCourses.filter(course => new Date(course.creationDate).getMonth()+1 == month.value)

       }

       getAllAvailableCourse(){
        this.http.post('http://localhost:54921/api/Course/ReturnAllCourses/0',null).subscribe((res:any)=>{
            this.availableCourses=res
            for(let course of res){
               this.GetCourseRating(course.courseId)
            }
         })
     }
     GetCourseRating(courseId:number){
        this.http.post('http://localhost:54921/api/Course/GetCourseRatings/'+courseId,null)
        .subscribe((res:any)=>{

          this.coursesSumationOfReview.push(res.length)

          if(res.length>0){
          for(let userRate of res){

             this.summationRate+=userRate.noOfStar
          }
          this.finalRate=this.summationRate/res.length
          this.coursesActualRating.push(Math.floor(this.finalRate))
         }else{
           this.coursesActualRating.push(0)
         }

        })
     }


     GetSingleCourseInfoById(P_courseId:number|undefined){
       this.http.post('http://localhost:54921/api/Course/ReturnAllCourses/0',null).subscribe((res:any)=>{

         for(let course of res){
           if(course.courseId==P_courseId){
             this.singleCourse=course;
             console.log(this.singleCourse)
           }
         }
      })

     }

     GetCourseTopic(P_courseId:number|undefined){
       this.http.post('http://localhost:54921/api/Course/GetCourseTopic/'+P_courseId,null)
          .subscribe((res:any)=>{
            this.courseTopic=res
          })
     }

     GetCourseComments(P_courseId:number|undefined){
       this.http.post('http://localhost:54921/api/Course/ReturnAllComments?courseId='+P_courseId+'&queryCode=0',null).subscribe((res:any)=>{
            this.courseComment=res;
       })
     }

     GetCourseSections(P_courseId:number|undefined){
       this.http.post('http://localhost:54921/api/Section/ReturnSectionByCourseId/'+P_courseId,null).subscribe((res:any)=>{
         this.courseSection=res;
       })
     }
     GetAvailableCartId(traineeId:number){
      this.http.post('http://localhost:54921/api/Customer/ReturnCart?queryCode=0&trineeId='+traineeId,null)
      .subscribe((res:any)=>{
        if(res.length>0){
          this.cartId=res[0].cartId
        }else{
          //create New Cart
          this.http.post('http://localhost:54921/api/Customer/InsertCart',{
            traineeId: traineeId
          }).subscribe((res)=>{
            this.GetAvailableCartId(traineeId)
          })
        }

      },err=>{

      })
    }

    GetAvailableWishListId(traineeId:number){
      this.http.post('http://localhost:54921/api/Customer/ReturnWishList/'+traineeId,null)
      .subscribe((res:any)=>{
        if(res.length>0){
          this.wishListId=res[0].wishListId;
        }else{
          //create New Wish List

          this.http.post('http://localhost:54921/api/Customer/InsertWishList',{
            traineeId: traineeId,
          }).subscribe((res)=>{
            this.GetAvailableWishListId(traineeId)
          })
        }

      })
    }

    AddCourseToWishList(wishListItem:any){

        this.http.post('http://localhost:54921/api/Customer/InsertWishListItem',wishListItem).subscribe((res)=>{
          if(res){
            this.toastr.success('Added To Wish List')
          }
        })
    }
     AddCourseToCart(cartItem:any){

      this.http.post('http://localhost:54921/api/Customer/InsertCartItem', cartItem).subscribe((res)=>{
        console.log(res)
        if(res){
          this.toastr.success('Finally Added')
        }

      })
    }



}

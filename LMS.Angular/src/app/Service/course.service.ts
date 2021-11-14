import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';
import { Coupon, Course } from '../models/course';
import { Topic } from '../models/topic';

@Injectable({
  providedIn: 'root'
})
export class CourseService {


  courses: Course[]=[];



  constructor(private http: HttpClient,private toastr:ToastrService) { }

//get course

  getCourses(){


    // const contactUs : ContactUs = this.contactUsForm.value;

    // debugger;
    //  this.spinner.show();

     this.http.post(environment.apiUrl + 'Course/ReturnAllCourses/1',1).subscribe((res:any)=>{
      // debugger
      // this.spinner.hide();
      // this.toastr.success('Send Message successfully, Thank You :)');
      debugger
      console.log(res)
      this.courses = res;

      // this.cor  = res;
      // window.location.reload();
      // console.log( "test",this.courses)
      // this.toastr.success('Data Retrived !!!');


    },err=>{
      // this.spinner.hide();
      // this.toastr.warning('Something wrong');
    })
    debugger;



  }

//delete Course

  deleteCourse(courseId:number){


    // const contactUs : ContactUs = this.contactUsForm.value;

    // debugger;
    //  this.spinner.show();

    this.http.put(environment.apiUrl + 'Course/DeleteCourse/'+courseId,courseId).subscribe((res:any)=>{
      // debugger
      // this.spinner.hide();
      // this.toastr.success('Send Message successfully, Thank You :)');
      debugger
      console.log(res)
      this.courses = res;
      // console.log( "test",this.courses)
      window.location.reload();
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
    this.http.post(environment.apiUrl + 'Course/InsertCourse/',course).subscribe((res:any)=>{
      debugger
      // this.spiner.hide();
      this.toastr.success('Course Created successfully !!!');

      window.location.reload()

    },err=>{
      // this.spiner.hide();
      this.toastr.error('Something Wrong, Try Again!');
    })
  }


  //update course

  updateCourse(course:any){

     debugger;
    //  this.spinner.show();

    this.http.put(environment.apiUrl + 'Course/UpdateCourse',course).subscribe((res:any)=>{
      debugger
      // this.spinner.hide();

      this.toastr.success('Course Updated successfully !!!');
      window.location.reload();

    },err=>{
      // this.spinner.hide();
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

      this.http.put(environment.apiUrl + 'Course/DeleteTopic/'+topicId,topicId).subscribe((res:any)=>{
      })

    }

    createTopic(topic:any){


    debugger
      this.http.post(environment.apiUrl + 'Course/InsertTopic/',topic).subscribe((res:any)=>{


        window.location.reload()
        this.toastr.success('Topic Created successfully !!!');

      },err=>{
        // this.spiner.hide();
        this.toastr.error('Something Wrong, Try Again!');
      })

      debugger
    }

    updateTopic(topic:any){

      debugger
            this.http.put(environment.apiUrl + 'Course/UpdateTopic/',topic).subscribe((res:any)=>{


              this.toastr.success('Topic updated successfully !!!');

              window.location.reload()
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
      this.toastr.error('Something Wrong, Try Again!');
    })

    debugger
    }
}

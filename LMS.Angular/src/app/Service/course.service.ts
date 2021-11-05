import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';
import { Course } from '../models/course';

@Injectable({
  providedIn: 'root'
})
export class CourseService {

  courses: Course[]=[];

  constructor(private http: HttpClient,private toastr:ToastrService) { }


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
      // console.log( "test",this.courses)
      // this.toastr.success('Data Retrived !!!');


    },err=>{
      // this.spinner.hide();
      // this.toastr.warning('Something wrong');
    })
    debugger;



  }
}

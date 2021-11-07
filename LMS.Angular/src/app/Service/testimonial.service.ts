import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';
import { Testimonial } from '../models/testimonial';
 
@Injectable({
  providedIn: 'root'
})
export class TestimonialService {
  testimonial: Testimonial[]=[];

  constructor(private http: HttpClient,private toastr:ToastrService) { }


  getTestimonial(){

    debugger;
    //  this.spinner.show();

     this.http.post(environment.apiUrl + 'ContactUs/GetUserTestimonails/1',1).subscribe((res:any)=>{
      debugger
      // this.spinner.hide();
      debugger
      console.log(res)
      this.testimonial = res;
      // console.log( "test",this.courses)
      // this.toastr.success('Data Retrived !!!');


    },err=>{
      // this.spinner.hide();
      // this.toastr.warning('Something wrong');
    })
    debugger;



  }
}

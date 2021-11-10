import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';
import { Section } from '../models/section';

@Injectable({
  providedIn: 'root'
})
export class SectionService {

   section: any=[{}];
  sections: any=[{}];

  

  constructor(private http: HttpClient,private toastr:ToastrService, private spinner: NgxSpinnerService,private router:Router) { }


  getAllSection(){

    this.spinner.show();
   this.http.get(environment.apiUrl + 'Section/GetAllSection').subscribe((res:any)=>{
    console.log()
    this.section = res;
    console.log('this is me' , this.section)
   this.sections = this.section;
   console.log('this is me' , this.sections)
   this.router.navigate(['trainer']);
   this.spinner.hide();

  },err=>{
    this.spinner.hide();
    this.toastr.warning('Something wrong');
  })
}


getSections(courseId:number){

  // debugger;
  //  this.spinner.show();

   this.http.post(environment.apiUrl + 'Section/ReturnSectionByCourseId/'+courseId,courseId).subscribe((res:any)=>{
    // debugger
    // this.spinner.hide();
    // this.toastr.success('Send Message successfully, Thank You :)');
    debugger
    console.log(res)
    this.sections = res;
    // console.log( "test",this.courses)
    this.toastr.success('Data Retrived !!!');


  },err=>{
    // this.spinner.hide();
    // this.toastr.warning('Something wrong');
  })
  debugger;



} 
  getSectionsById(courseId:number){

     this.spinner.show();

     this.http.post(environment.apiUrl + 'Section/ReturnSectionByCourseId/'+courseId,courseId).subscribe((res:any)=>{
       this.spinner.hide();
      this.toastr.success('Send Message successfully, Thank You :)');
      console.log(res)
      this.section = res;
      console.log( "test",this.section)
      this.toastr.success('Data Retrived !!!');


    },err=>{
      // this.spinner.hide();
      // this.toastr.warning('Something wrong');
    })
    debugger;



  }



}

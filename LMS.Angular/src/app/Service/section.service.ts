import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';
import { Section } from '../models/section';

@Injectable({
  providedIn: 'root'
})
export class SectionService {

  sections: Section[]=[];

  constructor(private http: HttpClient,private toastr:ToastrService) { }


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



}

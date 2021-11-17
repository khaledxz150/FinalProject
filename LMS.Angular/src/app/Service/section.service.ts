import { HttpClient } from '@angular/common/http';
import { Injectable, SecurityContext } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';
import { AlertDialogComponent } from '../alert-dialog/alert-dialog.component';
import { Section } from '../models/section';

import { DomSanitizer, SafeResourceUrl } from '@angular/platform-browser';

@Injectable({
  providedIn: 'root'
})
export class SectionService {
  myBase64!: SafeResourceUrl;

   section: any[]=[{}];
   TrainerSection : any;
   sections: any[]=[{}];
   status: any[]=[{}];
   SelectedSection:any|undefined;



  constructor(private http: HttpClient,private toastr:ToastrService, private spinner: NgxSpinnerService,private router:Router,
    private sanitizer: DomSanitizer) { }


  ReturnAllTrainerSections(TrainerId:any) {
    this.spinner.show();
   this.http.post(environment.apiUrl + 'Section/ReturnAllTrainerSections/'+TrainerId,TrainerId).subscribe((result:any)=>{
this.TrainerSection = result;
     this.TrainerSection.forEach((element: { courseImage: SafeResourceUrl; }) => {
      this.myBase64 = this.sanitizer.bypassSecurityTrustResourceUrl(
        `data:image/png;base64, ${element.courseImage}`


        );
        this.spinner.hide();

     this.sanitizer.sanitize(SecurityContext.HTML,this.myBase64);
      element.courseImage = this.myBase64;
     }) ;

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
    // this.toastr.success('Data Retrived !!!');


  },err=>{
    // this.spinner.hide();
    // this.toastr.warning('Something wrong');
  })
  debugger;



}

/////////
getSectionsById(courseId:number){

    //  this.spinner.show();

     this.http.post(environment.apiUrl + 'Section/ReturnSectionByCourseId/'+courseId,courseId).subscribe((res:any)=>{
      //  this.spinner.hide();
      console.log(res)
      this.section = res;
      // this.toastr.success('Data Retrived !!!');


    },err=>{
      // this.spinner.hide();
      this.toastr.warning('Something wrong');
    })
    debugger;



  }




  getStatus(){

    // debugger;
//  this.spinner.show();

this.http.get(environment.apiUrl + 'Section/GetAllStatus/').subscribe((res:any)=>{
  // debugger
  // this.spinner.hide();
  // this.toastr.success('Send Message successfully, Thank You :)');
  debugger
  console.log(res)
  this.status = res;
  // console.log( "test",this.courses)
  // this.toastr.success('Data Retrived !!!');


},err=>{
  // this.spinner.hide();
  // this.toastr.warning('Something wrong');
})
debugger;

}


createSection(section:Section,trainerId:number){



   debugger
   this.spinner.show()
  this.http.post(environment.apiUrl + 'Section/AddSection/'+trainerId,section).subscribe((res:any)=>{
    // debugger
    this.spinner.hide();
    this.toastr.success('Section Created Successfully');
    debugger


    // console.log( "test",this.courses)
    // this.toastr.success('Data Retrived !!!');


  },err=>{
    this.spinner.hide();
    this.toastr.warning('Something wrong');
  })
  debugger;;


}

deleteSection(sectionId:number){
  this.spinner.show();
  this.http.delete(environment.apiUrl + 'Section/DeleteSection/'+sectionId).subscribe((res:any)=>{
     debugger

    window.location.reload();
    this.spinner.hide();

    this.toastr.success('Course Deleted successfully !!!');

  },err=>{
    this.spinner.hide();
    this.toastr.error('Something Wrong, Try Again!');
  })
  debugger;
 }


 updateSection(section:Section,trainerId:number){



  debugger
  this.spinner.show();
 this.http.put(environment.apiUrl + 'Section/UpdateSection/'+trainerId,section).subscribe((res:any)=>{
   // debugger

   window.location.reload();
   this.spinner.hide();
   this.toastr.success('Section Updated Successfully');
   debugger


   // console.log( "test",this.courses)
  //  this.toastr.success('Data Retrived !!!');


 },err=>{
   this.spinner.hide();
   this.toastr.warning('Something wrong');
 })
 debugger;;


 }

 SetSection(sectionId:number){ this.SelectedSection = sectionId;}


 traineeSection:any[]=[{}]
 filterTraineeSection:any[]=[{}]
 ReturnTraineeSection(sectionId:number){
  debugger
  this.http.post(environment.apiUrl + 'Section/ReturnTraineeSection/'+sectionId,null).subscribe((res:any)=>{
    // debugger
    // this.spinner.hide();
    // this.toastr.success('Send Message successfully, Thank You :)');
    debugger
    this.traineeSection = res
    this.filterTraineeSection =  res
    // console.log( "test",this.courses)
    this.toastr.success('Data Retrived !!!');


  },err=>{
    // this.spinner.hide();
    this.toastr.warning('Something wrong');
  })
 }

 TraineeSection(sectionId:any){
   debugger
  this.filterTraineeSection =  this.traineeSection.filter(i=>i.sectionId == sectionId.value)

  debugger
 }
}

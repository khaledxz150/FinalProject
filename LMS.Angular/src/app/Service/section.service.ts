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
import { Attendance } from '../models/Attendance';

@Injectable({
  providedIn: 'root'
})
export class SectionService {
  myBase64!: SafeResourceUrl;
  CurrentLecture: any;

   section: any[]=[{}];
   TrainerSection : any[]=[{}];
   sections: any[]=[{}];
   status: any[]=[{}];
   SelectedSection:any|undefined;
   tasks:any[]=[];
   tasksAnswers:any=[]=[];
   TrainerSectionId: any;
   currentsectionforLecture: any;

  constructor(private http: HttpClient,private toastr:ToastrService, private spinner: NgxSpinnerService,private router:Router,
    private sanitizer: DomSanitizer) { }

    reloadComponent() {
      let currentUrl = this.router.url;
          this.router.routeReuseStrategy.shouldReuseRoute = () => false;
          this.router.onSameUrlNavigation = 'reload';
          this.router.navigate([currentUrl]);
      }
  ReturnAllTrainerSections(TrainerId:any) {
    this.spinner.show();
   this.http.post(environment.apiUrl + 'Section/ReturnAllTrainerSections/'+TrainerId,TrainerId).subscribe((result:any)=>{
this.TrainerSection = result;
this.spinner.hide();
     this.TrainerSection.forEach((element) => {
      this.myBase64 = this.sanitizer.bypassSecurityTrustResourceUrl(
        `data:image/png;base64, ${element.courseImage}`
      );
     this.sanitizer.sanitize(SecurityContext.HTML,this.myBase64);
      element.courseImage = this.myBase64;

     }) ;

  this.spinner.hide();
  },err=>{
    this.spinner.hide();
    this.toastr.warning('Something wrong');
  })
}

InsertTaskMarkForTrainee(obj:any){
  this.http.put('http://localhost:54921/api/Section/UpdateTraineeTask',obj).subscribe((res)=>{

  })
}

getSections(courseId:number){
   this.spinner.show();
   this.http.post(environment.apiUrl + 'Section/ReturnSectionByCourseId/'+courseId,courseId).subscribe((res:any)=>{
    debugger
    this.sections = res;
    // this.toastr.success('Data Retrived !!!');
    this.spinner.hide();
  },err=>{
    // this.spinner.hide();
    // this.toastr.warning('Something wrong');
  })
  debugger;



}

/////////
getSectionsById(courseId:number){

     this.spinner.show();

     this.http.post(environment.apiUrl + 'Section/ReturnSectionByCourseId/'+courseId,courseId).subscribe((res:any)=>{
       this.spinner.hide();
      this.toastr.success('Send Message successfully, Thank You :)');
      console.log(res)
      this.section = res;
      console.log( "test",this.section)
      this.toastr.success('Data Retrived !!!');

///jjk
    },err=>{
      // this.spinner.hide();
      // this.toastr.warning('Something wrong');
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
  this.http.post(environment.apiUrl + 'Section/AddSection/'+trainerId,section).subscribe((res:any)=>{
    // debugger
    // this.spinner.hide();
    // this.toastr.success('Send Message successfully, Thank You :)');
    debugger


    // console.log( "test",this.courses)
    this.toastr.success('Data Retrived !!!');

    window.location.reload()

  },err=>{
    // this.spinner.hide();
    this.toastr.warning('Something wrong');
  })
  debugger;;


}
arr : Attendance =new Attendance();


AddAttendance(trainerId:number){



  debugger
  this.spinner.show()
 this.http.post(environment.apiUrl + 'Employee/AddAttendanceTrainee/',trainerId).subscribe((res:any)=>{
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
  this.http.delete(environment.apiUrl + 'Section/DeleteSection/'+sectionId).subscribe((res:any)=>{
     debugger
    // this.spinner.hide();

    window.location.reload();
    this.toastr.success('Course Deleted successfully !!!');

  },err=>{
    // this.spinner.hide();
    this.toastr.error('Something Wrong, Try Again!');
  })
  debugger;
 }


 updateSection(section:Section,trainerId:number){



   this.spinner.show();

 this.http.put(environment.apiUrl + 'Section/UpdateSection/'+trainerId,section).subscribe((res:any)=>{

   this.spinner.hide();

   this.toastr.success('Section Updated Successfully!!');

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

 CreateNewTaskForSection(object:any){
   this.http.post('http://localhost:54921/api/Section/InsertTask',object).subscribe((res)=>{
     if(res){
       this.toastr.success('uploaded Success')
     }else{
       this.toastr.error('Failed Operation')
     }
   })
   window.location.reload();
 }


 GetTrainerSectionTask(sectionId:any){

  const current= this.TrainerSection.find(x=>x.sectionId == sectionId);

  this.TrainerSectionId=current.trainerSectionId;

debugger
  this.http.post(`http://localhost:54921/api/Section/ReturnTasksOfSection?sectionTrainerId=${this.TrainerSectionId}`,null)
  .subscribe((res:any)=>{
     this.tasks=res;
  })
 }

 GetTraineeSectionTaskAnswer(){
   this.http.post('http://localhost:54921/api/Section/ReturnSolutionOfTask?taskId=1&sectionId=1',null).subscribe((res:any)=>{
     this.tasksAnswers=res;
   })
 }

 studentsInfoAttend:any[]=[];
 studentsAttendenceArray:any[]=[];
 ReturnLectureBySectionId(SectionId:number){
  this.http.post(`http://localhost:54921/api/Section/ReturnLectureBySectionId=${SectionId}`,null).subscribe((res:any)=>{

this.CurrentLecture= res;
this.CurrentLecture = this.CurrentLecture.filter(((x: { sectionId: number; })=>x.sectionId==SectionId));
var LectureMax = 0;
for(let data of this.CurrentLecture){
if(data.lectureId >= LectureMax)
LectureMax = data.lectureId;
}
this.CurrentLecture = LectureMax;
  })



 }

 GetTraineeInSpecificSection(SectionId:number){
  this.http.post(`http://localhost:54921/api/Section/ReturnTraineeInSection?sectionId=${SectionId}`,null).subscribe((res:any)=>{
     this.studentsInfoAttend=res
     for(let i of this.studentsInfoAttend){
      const attendanceObject={
        studentId:i.trineeId,
        studentName:i.traineeName,
        isPresent:false,
        lectureId:this.CurrentLecture}
      this.studentsAttendenceArray.push(attendanceObject)
    }
   })
 }

 SaveAttendenceReport(){
  for(let i of this.studentsAttendenceArray){
    const attend={
      traineeId: i.studentId,
      isPresent: i.isPresent,
      lectureId: this.CurrentLecture,
      createdBy: 1,
    }
    this.http.post('http://localhost:54921/api/Section/InsertTraineeAttendance',attend).subscribe((res)=>{

    })
  }
 }
}

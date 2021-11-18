import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
//Update
export class LearningService {
  myEnrollment:any[]=[];
  myLiveSections:any[]=[];
  myOnlineCourses:any[]=[];
  myNewestCourses:any[]=[];

  constructor(private http:HttpClient) { }
  GetAllEnrollmentCourses(traineeId:number|undefined){
    this.http.post('http://localhost:54921/api/Customer/ReturnEnrollmentCourses/'+traineeId,null).subscribe((res:any)=>{
      this.myEnrollment=res;
      console.log(res);
      this.GetNewsetCoursesAndOnline(res)
    })
  }

  GetNewsetCoursesAndOnline(array:any){
    this.myLiveSections=[];
    this.myNewestCourses=[];
    this.myOnlineCourses=[];
    for(let course of array){
      console.log(course)

     this.http.post('http://localhost:54921/api/Customer/ReturnSectionCount?traineeId='+2+'&courseId='+course.courseID,null).subscribe((res:any)=>{
        if(res.sectionCount==0&&course.typeName!="Online"){
          console.log("New Course Need To Book Seat In Section")
          this.myNewestCourses.push(course)
          console.log(this.myNewestCourses)

        }else if(course.typeName=="Online"){
          this.myOnlineCourses.push(course)

        }else{
          this.myLiveSections.push(course)
        }


      })
   }
  }
}

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
@Injectable({
  providedIn: 'root'
})
export class LearningService {
  myEnrollment:any[]=[];
  myLiveSections:any[]=[];
  myOnlineCourses:any[]=[];
  myNewestCourses:any[]=[];

  constructor(private http:HttpClient) { }
  GetAllEnrollmentCourses(traineeId:number|undefined){
    this.http.post('http://localhost:54921/api/Customer/ReturnEnrollmentCourses/'+traineeId,null).subscribe((res:any)=>{
      this.myEnrollment=res;
    })
  }

  GetAllLiveCourses(traineeId:number|undefined){
    this.myNewestCourses=this.myEnrollment
    this.http.post('http://localhost:54921/api/Customer/ReturnLiveCourses/'+traineeId,null).subscribe((res:any)=>{
      this.myLiveSections=res;
    })
  }
  GetOnlineCourses(){

    for(let course of this.myEnrollment){
      if(course.typeName=="Online"){
        this.myOnlineCourses.push(course)

        this.myNewestCourses.splice(this.myNewestCourses.indexOf(course),1);

      }
    }
  }
}

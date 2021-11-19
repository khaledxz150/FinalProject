import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';
@Injectable({
  providedIn: 'root'
})
//Update Jasser
export class MySectionService {
  mySections:any[]=[];
  sectionUnits:any[]=[];
  sectionTask:any[]=[];
  sectionExam:any[]=[]
  sectionComment:any[]=[];
  sectionId:number=0;
  traineeId:number=0;
  courseId:number=0;
  comment:string='';
  singleSectionInfo:any;
  taskInfo:any;
  singleSectionExam:any;
  constructor(private http:HttpClient,public tostar:ToastrService) { }

  GetMySectionInfo(traineeId:number|undefined,){
    this.http.post('http://localhost:54921/api/Customer/ReturnSection/'+traineeId,null).subscribe((res:any)=>{
      this.mySections=res;
    })
  }

  GetSectionUnit(sectionId:number|undefined){
    this.http.post('http://localhost:54921/api/Section/ReturnSectionUnits/'+sectionId,null).subscribe((res:any)=>{
      this.sectionUnits=res;
    })
  }

  UploadTaskSolutionByTrainee(obj :any){
    this.http.post('http://localhost:54921/api/Section/InsertTraineeTask',obj).subscribe((res)=>{
       if(res){
        this.tostar.success('Uploaded Success')
       }

       },err=>{
         console.log(err)
      this.tostar.error('Failed Operaiton')
    })
  }

  GetSectionTask(sectionId:number|undefined){
    this.http.get('http://localhost:54921/api/Section/SelectTraineeSectionTaskId?sectionId='+sectionId)
    .subscribe((res:any)=>{
      this.sectionTask=res;

    })
  }
  GetSectionInfoById(taskId:number){
    this.http.get('http://localhost:54921/api/Section/SelectTraineeSectionTaskId')
    .subscribe((res:any)=>{
      console.log(res)
      console.log(taskId)
      for(let section of res){
        console.log(section)
        if(section.taskId==taskId){
          this.taskInfo=section
        }
      }
    })
  }
  GetSectionExam(sectionId:number|undefined){
    this.http.post('http://localhost:54921/api/Exam/ReturnExam?queryCode=1&sectionId='+sectionId,null)
    .subscribe((res:any)=>{
      this.sectionExam=res;
    })
  }
  GetExamInfoById(examId:number){
    this.http.post('http://localhost:54921/api/Exam/ReturnExam/1',null)
    .subscribe((res:any)=>{
      for(let exam of res){
        console.log(exam)
        if(exam.examId==examId){
          this.singleSectionExam=exam;


        }
      }
    })
  }

  SaveComment(){
    this.sectionId=1;
    this.traineeId=4

    const com:any={
      description: "Taltaen",
      sectionId: 1,
      courseId: 1,
      createdBy: 4,
    }
    this.http.post('http://localhost:54921/api/Course/InsertComment',com).subscribe((res)=>{
      if(res){
        this.tostar.success('Added Success')
      }
    })
  }
  SaveRate(numStar:number,note:string){
    const rate:any={
      noOfStar:numStar ,
      rateNote:note ,
      sectionId: 1,
      traineeId: 4,
    }
    this.http.post('http://localhost:54921/api/Course/InsertCourseRate',rate)
       .subscribe((res)=>{
        if(res){
          this.tostar.success('Added Success')
        }
       })
  }
  GetSectionComment(sectionId:number|undefined){
    this.http.post('http://localhost:54921/api/Section/ReturnAllComments/'+sectionId,null)
    .subscribe((res:any)=>{
      this.sectionComment=res;
    })
  }
  GetSingleSectionInformation(sectionId:number|undefined){
      this.http.post('http://localhost:54921/api/Section/GetSingleSection/'+sectionId,null).subscribe((res:any)=>{
        this.singleSectionInfo=res
      })
  }






}

import { HttpClient } from '@angular/common/http';
import { Injectable, Query } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
@Injectable({
  providedIn: 'root'
})
//Update Jasser
export class ExamService {
  QuestionAnswer:any[]=[];
  CurrentExam:any|undefined;
  actualExamId:number|undefined;
    constructor(  private http: HttpClient,
       private spinner:NgxSpinnerService,
       private toastr:ToastrService,
       private router:Router) {
     }
   GetQuestionFromDataBase(ExamId:any){
     this.actualExamId=ExamId
     this.spinner.show();

     this.http.post(`http://localhost:54921/api/Exam/ReturnExamQuestionAnswer/${ExamId}`,null)
     .subscribe((res:any)=>{
      this.QuestionAnswer = res;
      console.log(this.QuestionAnswer);
      this.spinner.hide();
   })

  }

  TraineeMarks:any[]=[];
  GetTraineeExamMarks(examId:number){
    this.http.post('http://localhost:54921/api/Exam/GetExamMarkList?examId='+examId,null).subscribe((res:any)=>{
      this.TraineeMarks=res;
    })
  }


   InsertExamResult(result:number|undefined){
    let user:any = localStorage.getItem('user');
    let trainee = JSON.parse(user);
    var traineeId = parseInt(trainee.TraineeId)
    const record={
      examId:this.actualExamId ,
      mark: result,
      traineeId:traineeId
    }
     this.http.post('http://localhost:54921/api/Exam/AddTraineeSectionExam',record).subscribe((res)=>{
       if(res){
         this.toastr.success('Your Result Is '+result+'/25 \n Thank You Very Much')
       }

     })
   }

}

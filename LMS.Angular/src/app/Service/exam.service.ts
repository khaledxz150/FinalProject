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
  fetchQuestion:any[]=[];
  QuestionsAnswer:any[]=[];
    constructor(  private http: HttpClient,
       private spinner:NgxSpinnerService,
       private toastr:ToastrService,
       private router:Router) {
     }
   GetQuestionFromDataBase(){
     this.spinner.show();
     this.QuestionsAnswer=[];
     this.fetchQuestion=[];
     this.http.post('http://localhost:54921/api/Exam/ReturnExamQuestion?queryCode=0&courseId=1',null)
     .subscribe((res:any)=>{
       this.fetchQuestion=res;
       for(let q of res){
         this.http.post('http://localhost:54921/api/Exam/ReturnExamOption?queryCode=0&questionId='+q.questionId,null).subscribe((res3:any)=>{
            this.QuestionsAnswer.push(res3)
            console.log(q.description)
            console.log(res3)
         })
       }
     })
   }
   InsertExamResult(result:any){

   }

}

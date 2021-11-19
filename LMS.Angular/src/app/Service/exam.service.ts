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
    constructor(  private http: HttpClient,
       private spinner:NgxSpinnerService,
       private toastr:ToastrService,
       private router:Router) {
     }
   GetQuestionFromDataBase(ExamId:any){
     this.spinner.show();
    
     this.http.post(`http://localhost:54921/api/Exam/ReturnExamQuestionAnswer/${ExamId}`,null)
     .subscribe((res:any)=>{   
      this.QuestionAnswer = res;
      console.log(this.QuestionAnswer);
      this.spinner.hide();
   })
  
  }


   InsertExamResult(result:any){

   }

}

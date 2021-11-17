import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';
import { Question } from '../models/ExamQuestion';
import { SectionService } from './section.service';
@Injectable({
  providedIn: 'root'
})
export class ExamServiceService {
  CreateAnswer(Answer: import("../models/QuestnAnswer").Answer[]) {
    throw new Error('Method not implemented.');
  }
  CurrentQuestionId: String | undefined;
  CreateQuestion(Question: Question) {
    throw new Error('Method not implemented.');
  }

    exam:any[]=[{}];
    SelectedExam:any;
    SelectedExamByID:any[]=[];
    currentExamId:any|undefined;

    constructor(  private http: HttpClient,
    private spinner:NgxSpinnerService,
    private toastr:ToastrService,
    private router:Router) {
     }

     GetExamBySection(sectionId:number){
      console.log(sectionId)
      this.spinner.show();
      this.http.post(environment.apiUrl + 'exam/ReturnExamBySectionId/'+sectionId,sectionId).subscribe((res:any)=>{
      this.exam = res;
    
      this.spinner.hide();
  
    },err=>{
      this.spinner.hide();
      this.toastr.warning('Something wrong');
    })
     }

     CreatExam(Exam:any){
      this.spinner.show();
      this.http.post(environment.apiUrl + 'exam/InsertExam',Exam).subscribe((res:any)=>{
      this.exam = res;
      this.spinner.hide();
  
    },err=>{
      this.spinner.hide();
      this.toastr.warning('Something wrong');
    })
     }

     UpdateExam(Exam:any){
      this.spinner.show();
      
      this.http.put(environment.apiUrl + 'exam/UpdateExam',Exam).subscribe((res:any)=>{
        
      this.spinner.hide();
  
    },err=>{
      this.spinner.hide();
      this.toastr.warning('Something wrong');
    })
     }

    
}

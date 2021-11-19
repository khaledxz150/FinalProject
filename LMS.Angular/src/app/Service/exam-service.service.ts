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

  Questions: any[]=[{}];
 
  CurrentQuestionId: String | undefined;


    exam:any[]=[{}];
    SelectedExam:any;
    SelectedExamByID:any[]=[];
    currentExamId:any|undefined;
    selectedSection:any|undefined;

    constructor(  private http: HttpClient,
    private spinner:NgxSpinnerService,
    private toastr:ToastrService,
    private router:Router) {
     }

     GetExamBySection(sectionId:number){
      this.spinner.show();
      this.http.post(environment.apiUrl + 'exam/ReturnExamBySectionId/'+sectionId,sectionId).subscribe((res:any)=>{
      this.exam = res;
      this.selectedSection = sectionId;
      this.spinner.hide();
  
    },err=>{
      this.spinner.hide();
      this.toastr.warning('Something wrong');
    })
     }

     CreatExam(Exam:any){
      this.spinner.show();
      this.http.post(environment.apiUrl + 'exam/InsertExam',Exam).subscribe((res:any)=>{
      this.reloadComponent();
      this.GetExamBySection(this.selectedSection);
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
      this.reloadComponent();
      this.GetExamBySection(this.selectedSection);
      this.spinner.hide();
    },err=>{
      this.spinner.hide();
      this.toastr.warning('Something wrong');
    })
     }


     InsertExamQuestion(Question:any){
      this.spinner.show();
      this.http.post(environment.apiUrl + 'Exam/InsertExamQuestionAnswer',Question).subscribe((res:any)=>{ 
this.ReturnExamQuestion();
      this.spinner.hide();
    },err=>{
      this.spinner.hide();
      this.toastr.warning('Something wrong');
    })

     }


     ReturnExamQuestion(){
      this.spinner.show();
      this.http.post(environment.apiUrl + 'Exam/ReturnExamQuestionAnswer/'+this.currentExamId,this.currentExamId).subscribe((res:any)=>{ 
        this.Questions = res;
      this.spinner.hide();
    },err=>{
      this.spinner.hide();
      this.toastr.warning('Something wrong');
    })

     }
     DeleteQuestion(examQuestionAnswer: any) {
      this.spinner.show();
      this.http.delete(environment.apiUrl + 'Exam/DeleteExamQuestionAnswer/'+examQuestionAnswer,examQuestionAnswer).subscribe((res:any)=>{ 
        this.reloadComponent();
      this.spinner.hide();
    },err=>{
      this.spinner.hide();
      this.toastr.warning('Something wrong');
    })
    }

    reloadComponent() {
      let currentUrl = this.router.url;
          this.router.routeReuseStrategy.shouldReuseRoute = () => false;
          this.router.onSameUrlNavigation = 'reload';
          this.router.navigate([currentUrl]);
      }

    
}

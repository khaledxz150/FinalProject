import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';
import { SectionService } from './section.service';
@Injectable({
  providedIn: 'root'
})
export class ExamServiceService {

    exam:any[]=[{}];
    SelectedExam:any;
    SelectedExamByID:any[]=[];

    constructor(  private http: HttpClient,
    private spinner:NgxSpinnerService,
    private toastr:ToastrService,
    private router:Router,
    private secionService:SectionService) {
     }

     GetExamBySection(sectionId:number){
      this.spinner.show();
      this.http.post(environment.apiUrl + 'exam/ReturnExamBySectionId/'+sectionId,sectionId).subscribe((res:any)=>{
      this.exam = res;
    
      this.router.navigate(['trainer/exam']);
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
      this.GetExamBySection(this.secionService.SelectedSection);
      this.router.navigate(['trainer/exam']);
      this.spinner.hide();
  
    },err=>{
      this.spinner.hide();
      this.toastr.warning('Something wrong');
    })
     }

     UpdateExam(Exam:any){
      this.spinner.show();
      
      this.http.put(environment.apiUrl + 'exam/UpdateExam',Exam).subscribe((res:any)=>{
        
      this.GetExamBySection(this.secionService.SelectedSection);
      this.router.navigate(['trainer']);
      this.spinner.hide();
  
    },err=>{
      this.spinner.hide();
      this.toastr.warning('Something wrong');
    })
     }

    
}

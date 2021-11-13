import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';
@Injectable({
  providedIn: 'root'
})
export class ExamServiceService {

    exam:any[]=[{}];
    constructor(  private http: HttpClient,
    private spinner:NgxSpinnerService,
    private toastr:ToastrService,
    private router:Router) {
     }

     GetExamBySection(sectionId:number){
      this.spinner.show();
      debugger
      this.http.post(environment.apiUrl + 'exam/ReturnExamBySectionId/'+sectionId,sectionId).subscribe((res:any)=>{
      this.exam = res;
    
      this.router.navigate(['trainer/exam']);
      this.spinner.hide();
  
    },err=>{
      this.spinner.hide();
      this.toastr.warning('Something wrong');
    })
     }
}

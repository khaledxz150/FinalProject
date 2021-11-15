import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';
import { AlertDialogComponent } from '../alert-dialog/alert-dialog.component';
import { Section } from '../models/section';

@Injectable({
  providedIn: 'root'
})
export class LectureService {

  constructor(private http: HttpClient,private toastr:ToastrService, private spinner: NgxSpinnerService,private router:Router) { } 
     Lecture: any[]=[{}];

  CreateLecture(Lecture:any) {
    this.spinner.show();
   this.http.post(environment.apiUrl + 'Lecture/InsertLecture',Lecture).subscribe((result:any)=>{
  this.spinner.hide();
  },err=>{
    this.spinner.hide();
    this.toastr.warning('Something wrong');
  })
}
}

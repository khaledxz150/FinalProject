import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';
import { Course } from '../models/course';
import { Unit } from '../models/unit';

//Update Unit

@Injectable({
  providedIn: 'root'
})
export class UnitService {



  constructor(  private http: HttpClient,
    private spinner:NgxSpinnerService,
    private toastr:ToastrService,
    private router:Router) {
     }
  section:any=[{}];
  units: any=[{}];
sectionID:any = 0;

    getAllTrainerSectionUnit(SectionId:any){
      this.sectionID=SectionId;
      this.spinner.show();
      this.http.post(environment.apiUrl + 'Section/ReturnSectionUnits/'+SectionId,SectionId).subscribe((res:any)=>{
      this.units = res;
      this.router.navigate(['trainer/unit']);
      this.spinner.hide();
    },err=>{
      this.spinner.hide();
      this.toastr.warning('Something wrong');
    })
  }


 insertUnit(unit:Unit) {
  this.spinner.show();
      this.http.post(environment.apiUrl + 'Section/InsertUnit',unit).subscribe((res:any)=>{
      this.units = res;
      debugger
      this.router.navigate(['trainer/unit'])
      this.spinner.hide();

    },err=>{
      this.spinner.hide();
      this.toastr.warning('Something wrong');
    })
  }

  uploadFile(selectedFile: File) {
    throw new Error('Method not implemented.');
  }
}

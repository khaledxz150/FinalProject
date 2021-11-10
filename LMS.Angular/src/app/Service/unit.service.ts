import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { NgxSpinnerService } from 'ngx-spinner';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';
import { Course } from '../models/course';

type Unit = { Id: number; SectionId: number; FilePath: File; IsActive: boolean; CreationDate: Date; CreatedBy: number};

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
  unit: any=[{}];

  map = new Map<number, Unit[]>();
  unitfield:any=[{
  Id:1,
  SectionId:1,
  FilePath:"321321dsadsa"
},{
  Id:1,
  SectionId:1,
  FilePath:"321321dsadsa"
}]
    getAllSectionAndUnit(){
      this.spinner.show();
      this.http.get(environment.apiUrl + 'Section/GetAllSection').subscribe((res:any)=>{
      this.map.set(1,this.unitfield);
      console.log("Hello",this.map.get(1))
      this.section = res;
      this.spinner.hide();
  
    },err=>{
      this.spinner.hide();
      this.toastr.warning('Something wrong');
    })
  } 

}
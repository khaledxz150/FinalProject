import { HttpClient, HttpHeaders } from '@angular/common/http';
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
   headers = new HttpHeaders({ 'Content-Type': 'application/JSON' });



  constructor(  private http: HttpClient,
    private spinner:NgxSpinnerService,
    private toastr:ToastrService,
    private router:Router) {
     }
  section:any=[{}];
  units: any=[{}];
sectionID:any = 0;
reloadComponent() {
  let currentUrl = this.router.url;
      this.router.routeReuseStrategy.shouldReuseRoute = () => false;
      this.router.onSameUrlNavigation = 'reload';
      this.router.navigate([currentUrl]);
  }
    getAllTrainerSectionUnit(SectionId:any){

      this.spinner.show();
      this.http.post(environment.apiUrl + 'Section/ReturnSectionUnits/'+SectionId,null).subscribe((res:any)=>{
          if(res.length==0)
           {
             this.units =null;
          }
           else{
              this.units = res;
            }
    this.spinner.hide(); this.reloadComponent();
    },err=>{
    this.spinner.hide(); this.reloadComponent();
      this.toastr.warning('Something wrong');
    })
  }


 insertUnit(unit:Unit) {
  this.spinner.show();
      this.http.post(environment.apiUrl + 'Section/InsertUnit',unit).subscribe((res:any)=>{
      this.units = res;
    this.spinner.hide(); this.reloadComponent();

    },err=>{
    this.spinner.hide(); this.reloadComponent();
      this.toastr.warning('Something wrong');
    })
  }

  uploadFile(selectedFile: File) {
    throw new Error('Method not implemented.');
  }
}

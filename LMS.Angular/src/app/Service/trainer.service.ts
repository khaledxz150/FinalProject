import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class TrainerService {

  trainer: any[]=[{}]

  constructor(
    private http: HttpClient,
    private toastr:ToastrService
  ) { }


  getTrainer(){

    debugger;
    //  this.spinner.show();

     this.http.post(environment.apiUrl + 'Employee/GetAllEmployess/1',1).subscribe((res:any)=>{
      debugger
      // this.spinner.hide();
      debugger
      console.log(res)
      this.trainer = res;
      // console.log( "test",this.courses)
      // this.toastr.success('Data Retrived !!!');


    },err=>{
      // this.spinner.hide();
      // this.toastr.warning('Something wrong');
    })
    debugger;



  }
}

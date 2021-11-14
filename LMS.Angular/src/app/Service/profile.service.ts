import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';
@Injectable({
  providedIn: 'root'
})
export class ProfileService {
  traineeInfo:any={};
  constructor(private http: HttpClient,private toastr:ToastrService) {
   }
   GetMyProfile(){
     this.http.post('http://localhost:54921/api/Customer/ReturnTraineeInfo/2',null)
     .subscribe((res)=>{
       this.traineeInfo=res;
       console.log(this.traineeInfo)
     })
   }

}

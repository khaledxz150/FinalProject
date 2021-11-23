import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';
@Injectable({
  providedIn: 'root'
})
export class ProfileService {
  traineeInfo:any={};
  trainee:any;
  constructor(private http: HttpClient,private toastr:ToastrService) {
   }
   GetMyProfile(traineeId:any){
     this.http.post('http://localhost:54921/api/Customer/ReturnTraineeInfo/'+traineeId,null)
     .subscribe((res:any)=>{
       this.trainee=res;
      
      
      });
      console.log("this is trainne",this.trainee);
   }
}

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';
import { Purches } from '../models/purches';
import { CourseRefund } from '../models/CourseRefund';
import { environment } from 'src/environments/environment';
@Injectable({
  providedIn: 'root'
})

//Update
export class PurchesService {
  myPurshes:Purches[]=[];
  myRefunds:CourseRefund[]=[];
  purchesCount:number=0;
  purchesAmount:number=0;
  constructor(private http: HttpClient,private toastr:ToastrService) {}
  GetMyPurshes(){
    this.myPurshes=[];
     console.log("resa")
    this.http.get('http://localhost:54921/api/Customer/ReturnSoldCourses').subscribe((res:any)=>{
      for(let record of res){
        if(record.traineeId==2){
          this.myPurshes.push(record)
          this.purchesCount++;
          this.purchesAmount=this.purchesAmount+record.coursePrice;
        }
      }
    });
  }


  GetMyRefunds(traineeId:number){
    this.http.post(environment.apiUrl + 'CourseRefunds/ReturnCourseRefund/'+traineeId,traineeId).subscribe((res:any)=>{

      this.myRefunds=res;
    });
  }



  ApproveRefundReason(courseRefundsId:number){
    debugger
    this.http.put(environment.apiUrl + 'CourseRefunds/ApproveRefundReason/'+courseRefundsId,courseRefundsId).subscribe((res:any)=>{

      this.myRefunds=res;

      window.location.reload()
      this.toastr.success("Aprroved Refund Reason!")

    },err=>{
      this.toastr.warning("Somthing Wrong!")

    });
  }
}

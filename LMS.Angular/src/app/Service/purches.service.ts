import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ToastrService } from 'ngx-toastr';
import { Purches } from '../models/purches';
import { CourseRefund } from '../models/CourseRefund';
@Injectable({
  providedIn: 'root'
})
export class PurchesService {
  myPurshes:Purches[]=[];
  myRefunds:CourseRefund[]=[];
  purchesCount:number=0;
  purchesAmount:number=0;
  maincheckoutId:number|undefined;
  maincourseId:number|undefined;
  mainNotes:string|undefined;
  constructor(private http: HttpClient,private toastr:ToastrService) {}
  GetMyPurshes(traineeId:number){
    this.myPurshes=[];
    this.purchesCount=0;
    this.purchesAmount=0;
    this.http.get('http://localhost:54921/api/Customer/ReturnSoldCourses').subscribe((res:any)=>{
    for(let record of res){
        if(record.traineeId==traineeId){
          this.myPurshes.push(record)
          this.purchesCount++;
          this.purchesAmount=this.purchesAmount+record.coursePrice;
        }
      }
    });
  }
  GetMyRefunds(traineeId:number){
    this.http.post('http://localhost:54921/api/CourseRefunds/ReturnCourseRefund/'+traineeId,null).subscribe((res:any)=>{
      this.myRefunds=res;
    });
  }

  SendRefundRequest(){
    const object:any={
      checkoutId: this.maincheckoutId,
      refundsNotes: this.mainNotes,
      courseId: this.maincourseId
    }
    console.log(object)
    this.http.post('http://localhost:54921/api/CourseRefunds/InsertCourseRefunds',object).subscribe((res)=>{
      if(res){
        this.toastr.success('Your Request Sent Successfly')
      }
    },err=>{
      this.toastr.error('Failed Operation')
    })
  }

  ApproveRefundReason(courseRefundsId:number){
    debugger
    this.http.put('http://localhost:54921/api/CourseRefunds/ApproveRefundReason/'+courseRefundsId,courseRefundsId).subscribe((res:any)=>{

      this.myRefunds=res;

      window.location.reload()
      this.toastr.success("Aprroved Refund Reason!")

    },err=>{
      this.toastr.warning("Somthing Wrong!")

    });
  }

}

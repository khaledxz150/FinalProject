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
  constructor(private http: HttpClient,private toastr:ToastrService) {}
  GetMyPurshes(){
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
  GetMyRefunds(){
    this.http.post('http://localhost:54921/api/CourseRefunds/ReturnCourseRefund/2',null).subscribe((res:any)=>{
      this.myRefunds=res;
    });
  }

}

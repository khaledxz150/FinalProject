import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { CourseService } from './course.service';

//Update
@Injectable({
  providedIn: 'root'
})
export class SectionInfoService {

  singleSection:any={};
  constructor(private http: HttpClient,
    private courseService:CourseService,
    private toastr:ToastrService,private router:Router) {

     }

    GetFullSectionInfo(sectionId:number){
      this.http.get('http://localhost:54921/api/Section/GetSectionFullInfo?sectionId='+sectionId).subscribe((res)=>{
         this.singleSection=res
      })

     }
  GetSectionInfoById(sectionId:number|undefined){
    debugger
    for(let section of this.courseService.courseSection){
      debugger
      if(section.sectionId==sectionId){
        this.singleSection=section;
        console.log(this.singleSection)

      }
    }
  }
  RegisterInSection(traineeSection:any){
    this.http.post('http://localhost:54921/api/Section/InsertTraineeSection',traineeSection).subscribe((res)=>{
      if(res){
        this.toastr.success('Added Successfly')
      }else{
        this.toastr.error('Failed Operation')
      }
    })
  }

}

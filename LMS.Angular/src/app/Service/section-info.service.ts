import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { CourseService } from './course.service';

@Injectable({
  providedIn: 'root'
})
export class SectionInfoService {

  singleSection:any={};
  constructor(private http: HttpClient,
    private courseService:CourseService,
    private toastr:ToastrService,private router:Router) {

     }

  GetSectionInfoById(sectionId:number|undefined){
    for(let section of this.courseService.courseSection){
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

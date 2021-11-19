import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { parse } from 'querystring';
import { ExamServiceService } from 'src/app/Service/exam-service.service';
import { LectureService } from 'src/app/Service/lecture.service';
import { SectionService } from 'src/app/Service/section.service';

@Component({
  selector: 'app-create-lecture',
  templateUrl: './create-lecture.component.html',
  styleUrls: ['./create-lecture.component.css']
})
export class CreateLectureComponent implements OnInit {
  constructor(public lectureService: LectureService,
     public sectionService:SectionService,
      @Inject(MAT_DIALOG_DATA) public data: any,private router: Router) { }

  ngOnInit(): void { 
    let user:any = localStorage.getItem('user');
    let trainerId = JSON.parse(user);

    trainerId = trainerId.EmployeeId
    trainerId = parseInt(trainerId)
    const lecture =[{sectionId:this.data, createdby:trainerId}]
    debugger
    //trainerId}]
    this.lectureService.CreateLecture(lecture[0]);
  }
  Clicked(){
    this.sectionService.currentsectionforLecture = this.data;
    
    this.router.navigate(['trainer/attend']);
  }

}

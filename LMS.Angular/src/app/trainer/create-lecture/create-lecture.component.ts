import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
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
      @Inject(MAT_DIALOG_DATA) public data: any) { }

  ngOnInit(): void { 
    let user:any = localStorage.getItem('user');
    let trainerId = JSON.parse(user);
    const lecture =[{sectionId:this.data, createdby:2}]
    //trainerId}]
    this.lectureService.CreateLecture(lecture[0]);
  }
  

}

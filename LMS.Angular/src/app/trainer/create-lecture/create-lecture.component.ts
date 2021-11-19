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
  formGroup: FormGroup = new FormGroup({
    SectionId: new FormControl(this.data.sectionId),
    StartAt: new FormControl('', [Validators.required]),
    EndAt: new FormControl('', [Validators.required]),
    isActive: new FormControl(true),
    creationDate: new FormControl(new Date()),
    createdBy: new FormControl(1),
  });

  constructor(public lectureService: LectureService,
     public sectionService:SectionService,
      @Inject(MAT_DIALOG_DATA) public data: any) { }

  ngOnInit(): void {
    this.formGroup.controls.SectionId.setValue(this.data.sectionId);
    this.formGroup.controls.StartAt.setValue(this.data.sectionTimeStart);
    this.formGroup.controls.EndAt.setValue(this.data.sectionTimeEnd);
  }

  Create(){
    const values = this.formGroup.value
    let user:any = localStorage.getItem('user');

    let trainerId = JSON.parse(user);
     if(trainerId){
      values.createdBy = parseInt(trainerId.EmployeeId);
     }

    console.log(values);
    this.lectureService.CreateLecture(values);
  }

}

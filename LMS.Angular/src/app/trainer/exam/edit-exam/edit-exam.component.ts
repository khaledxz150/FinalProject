import { Component, Inject, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ExamServiceService } from 'src/app/Service/exam-service.service';
import { SectionService } from 'src/app/Service/section.service';
@Component({
  selector: 'app-edit-exam',
  templateUrl: './edit-exam.component.html',
  styleUrls: ['./edit-exam.component.css']
})
export class EditExamComponent implements OnInit {
  SelectedExam:any= [];
  formGroup: FormGroup = new FormGroup({
    examId: new FormControl(''),
    ExamDate: new FormControl( '', [Validators.required]),
    StartTime: new FormControl('', [Validators.required]),
    EndTime: new FormControl('', [Validators.required]),
    Mark: new FormControl('', [Validators.required]),
    Weight: new FormControl('', [Validators.required]),
  });

  constructor(public examService: ExamServiceService, public sectionService:SectionService,@Inject(MAT_DIALOG_DATA) public data: any) { }

  ngOnInit(): void {
   
this.formGroup.setValue({
  examId: this.data.examId,
  ExamDate: this.data.examDate,
  StartTime:this.data.startTime,
  EndTime: this.data.endTime,
  Mark:this.data.mark,
  Weight: this.data.weight
});

}
  Create(){
    const values = this.formGroup.value
    console.log(values);
    this.examService.UpdateExam(values);
  }

}

import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ExamServiceService } from 'src/app/Service/exam-service.service';
import { SectionService } from 'src/app/Service/section.service';

@Component({
  selector: 'app-create-exam',
  templateUrl: './create-exam.component.html',
  styleUrls: ['./create-exam.component.css']
})
export class CreateExamComponent implements OnInit {

  formGroup: FormGroup = new FormGroup({
    SectionId: new FormControl(this.sectionService.SelectedSection),
    ExamDate: new FormControl('', [Validators.required]),
    StartTime: new FormControl('', [Validators.required]),
    EndTime: new FormControl('', [Validators.required]),
    isActive: new FormControl(true),
    creationDate: new FormControl(new Date()),
    createdBy: new FormControl(1),
    Mark: new FormControl('', [Validators.required]),
    Weight: new FormControl('', [Validators.required]),
  });

  constructor(public examService: ExamServiceService, public sectionService:SectionService) { }

  ngOnInit(): void {
  }

  Create(){
    const values = this.formGroup.value
    console.log(values);
    this.examService.CreatExam(values);
  }
}

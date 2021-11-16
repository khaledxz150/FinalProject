import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { ExamServiceService } from 'src/app/Service/exam-service.service';
import { SectionService } from 'src/app/Service/section.service';

@Component({
  selector: 'app-exam-questions-answers',
  templateUrl: './exam-questions-answers.component.html',
  styleUrls: ['./exam-questions-answers.component.css']
})
export class ExamQuestionsAnswersComponent implements OnInit {

  
  formGroup: FormGroup;
  constructor(public examService: ExamServiceService, public sectionService:SectionService,@Inject(FormBuilder) fb: FormBuilder, @Inject(MAT_DIALOG_DATA) public data: any) { 

    this.formGroup = fb.group({
      Question: fb.group({
        examId: [this.data.examId],
        imageName: ['', Validators.required],
        courseId: ['', Validators.required],
        createdBy: [new Date()]

      }),
      Answer: fb.group({
          Answer1: ['', Validators.required],
          Answer2: ['', Validators.required],
          Answer3: ['', Validators.required],
          Answer4: ['', Validators.required]
      })
  });
  }

  ngOnInit(): void {
  }

  Create(){
    const values = this.formGroup.controls;
    console.log(values);
  }

}

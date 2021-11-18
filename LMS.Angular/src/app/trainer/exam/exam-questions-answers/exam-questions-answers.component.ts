import { Component, Inject, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Question } from 'src/app/models/ExamQuestion';
import { Answer } from 'src/app/models/QuestnAnswer';
import { ExamServiceService } from 'src/app/Service/exam-service.service';
import { SectionService } from 'src/app/Service/section.service';

@Component({
  selector: 'app-exam-questions-answers',
  templateUrl: './exam-questions-answers.component.html',
  styleUrls: ['./exam-questions-answers.component.css']
})
export class ExamQuestionsAnswersComponent implements OnInit {
Question:Question | undefined;
Answer1:Answer | undefined;
Answer2:Answer | undefined;
Answer3:Answer | undefined;
Answer4:Answer | undefined;
Answer:Answer[]=[];
formGroup: FormGroup;
  constructor(public examService: ExamServiceService, public sectionService:SectionService,@Inject(FormBuilder) fb: FormBuilder, @Inject(MAT_DIALOG_DATA) public data: any) { 


  
    this.formGroup = fb.group({
      Question: fb.group({
        examId: [this.examService.currentExamId],
        description:['', Validators.required],
        imageName: [''],
      }),
      Answer: fb.group({
          Answer1: ['', Validators.required],
          Answer2: ['', Validators.required],
          Answer3: ['', Validators.required],
          Answer4: ['', Validators.required],
          
      })
  });
  }

  ngOnInit(): void {  

  }

  Create(){
     this.Question={ description: this.formGroup.controls.Question.value.description, examId:this.examService.currentExamId,
      CorrectAnswer: this.formGroup.controls.Answer.value.Answer1, Option1:this.formGroup.controls.Answer.value.Answer2,
       Option2:this.formGroup.controls.Answer.value.Answer2, Option3:this.formGroup.controls.Answer.value.Answer3};
       debugger
      this.examService.InsertExamQuestion(this.Question);
  }

}

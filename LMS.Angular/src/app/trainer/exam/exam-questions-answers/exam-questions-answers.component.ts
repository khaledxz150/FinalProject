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
    console.log(this.formGroup.get('Answer1')?.hasError);
    // this.Question={ description: this.formGroup.controls.Question.value.description, ImageName:undefined, CreatedBy: 2};
    // this.examService.CreateQuestion(this.Question);
    // this.Answer1 ={ description:this.formGroup.controls.Answer1.value.description , 
    //   questionId:this.examService.CurrentQuestionId, isCorrect: true, createdBy:2}
    //   this.Answer2 ={ description:this.formGroup.controls.Answer1.value.description , 
    //     questionId:this.examService.CurrentQuestionId, isCorrect: false, createdBy:2}
    //     this.Answer3 ={ description:this.formGroup.controls.Answer1.value.description , 
    //       questionId:this.examService.CurrentQuestionId, isCorrect: false, createdBy:2}
    //       this.Answer4 ={ description:this.formGroup.controls.Answer1.value.description , 
    //         questionId:this.examService.CurrentQuestionId, isCorrect: false, createdBy:2}
    //     this.Answer.push(this.Answer1);
    //     this.Answer.push(this.Answer2);
    //     this.Answer.push(this.Answer3);
    //     this.Answer.push(this.Answer4);
    //     this.examService.CreateAnswer(this.Answer);

    // const values = this.formGroup.controls;
    // console.log(values);
  }

}

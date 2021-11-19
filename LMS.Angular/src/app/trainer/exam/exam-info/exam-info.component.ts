import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { ExamServiceService } from 'src/app/Service/exam-service.service';
import { ExamQuestionsAnswersComponent } from '../exam-questions-answers/exam-questions-answers.component';

@Component({
  selector: 'app-exam-info',
  templateUrl: './exam-info.component.html',
  styleUrls: ['./exam-info.component.css']
})
export class ExamInfoComponent implements OnInit {

  constructor(public examService:ExamServiceService, private dialog: MatDialog) { }

  ngOnInit(): void {
    this.examService.ReturnExamQuestion();
   
  }


  
  addQuestion(){
    this.dialog.open(ExamQuestionsAnswersComponent, {data:this.examService.currentExamId});
  }

  DeleteQuestion(examQuestionAnswer:any){
    this.examService.DeleteQuestion(examQuestionAnswer);
    this.examService.ReturnExamQuestion();
  }
}

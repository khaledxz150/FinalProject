import { Component, OnInit } from '@angular/core';
import { ExamService } from 'src/app/Service/exam.service';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ThrowStmt } from '@angular/compiler';
import { Router } from '@angular/router';

@Component({
  selector: 'app-questions',
  templateUrl: './questions.component.html',
  styleUrls: ['./questions.component.css']
})
export class QuestionsComponent implements OnInit {
   currentAnswer:string='';
  constructor(public exam:ExamService,public router:Router) { }
   examIndex:number=0;
   result:number=0;
   userAnswer:any[]=['','','','','','','','','','','','','','','','','','','','','','','','',''];
   ngOnInit(): void {
    this.exam.GetQuestionFromDataBase(11);
  }
  Next(){
    ++this.examIndex;
  }
  handleInput(ans:any){
    console.log(ans)
    this.userAnswer[this.examIndex]=ans;
  }
  Prevuois(){
      --this.examIndex;
  }

  FinshExam(){
   console.log(this.userAnswer)
    for(let ans=0;ans< this.exam.QuestionAnswer.length;ans++){

        if(this.exam.QuestionAnswer[ans].correctAnswer==this.userAnswer[ans]){
          ++ this.result;
        }

    }

    console.log(this.result)
    this.exam.InsertExamResult(this.result)
  }

}

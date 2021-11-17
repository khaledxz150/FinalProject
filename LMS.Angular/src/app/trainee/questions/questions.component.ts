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
    this.exam.GetQuestionFromDataBase()
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
    for(let ans=0;ans< this.exam.QuestionsAnswer.length;ans++){
      for(let i of this.exam.QuestionsAnswer[ans]){
        if(i.description==this.userAnswer[ans] && i.isCorrect){
          ++ this.result;
        }
      }
    }
    console.log(this.result)

    

    this.router.navigate(['client','sections'])
  }

}

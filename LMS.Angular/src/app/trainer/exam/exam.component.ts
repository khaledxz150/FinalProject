import { Component, OnInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { MatAccordion } from '@angular/material/expansion';
import { ExamServiceService } from 'src/app/Service/exam-service.service';
import { CreateExamComponent } from './create-exam/create-exam.component';

@Component({
  selector: 'app-exam',
  templateUrl: './exam.component.html',
  styleUrls: ['./exam.component.css']
})
export class ExamComponent implements OnInit {

  constructor(public examService:ExamServiceService, private dialog: MatDialog) { }
  @ViewChild(MatAccordion) accordion!: MatAccordion;

  ngOnInit(): void {
  }
  Change(e: any){
    const cardInfoBtn = e.target.closest('.card__more-info')
    const cardLessBtn = e.target.closest('.card__less-info')
    
    if (cardInfoBtn) {
      cardInfoBtn.parentNode.parentNode.classList.add('card--open')
    }
    
    if (cardLessBtn) {
      cardLessBtn.parentNode.parentNode.classList.remove('card--open')
    }
    
  }
  DeleteExam(sectionId: number){};

  addExam(){
    this.dialog.open(CreateExamComponent);
  }

  EditExam(examId:number){


  }

}

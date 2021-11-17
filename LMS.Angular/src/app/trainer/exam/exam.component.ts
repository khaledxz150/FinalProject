import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { ExamServiceService } from 'src/app/Service/exam-service.service';
import { SectionService } from 'src/app/Service/section.service';
import { CreateExamComponent } from './create-exam/create-exam.component';
import { EditExamComponent } from './edit-exam/edit-exam.component';

@Component({
  selector: 'app-exam',
  templateUrl: './exam.component.html',
  styleUrls: ['./exam.component.css']
})
export class ExamComponent implements OnInit {
@Input() Sectionid = 0;

  constructor(public examService:ExamServiceService, private dialog: MatDialog,private router:Router) { }

  ngOnInit(): void {
  }
  DeleteExam(sectionId: number){};
  addExam(){
    this.dialog.open(CreateExamComponent);
  }

  viewExamInfo(examId:any){
    this.examService.currentExamId = examId;
    debugger
    this.router.navigate(['trainer/examInfo'])
  }
  EditExam(examId:number){
  const item = this.examService.exam.find(x => x.examId == examId);
  this.dialog.open(EditExamComponent, { data: item });
  }


}

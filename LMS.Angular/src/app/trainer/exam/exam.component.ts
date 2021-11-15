import { Component, Input, OnInit, ViewChild } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
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
  constructor(public examService:ExamServiceService, private dialog: MatDialog, private sectionService: SectionService) { }
  ngOnInit(): void {
    this.ViewExam(this.Sectionid);

  }
  
  DeleteExam(sectionId: number){};

  addExam(){
    this.dialog.open(CreateExamComponent);
  }

  EditExam(examId:number){
  const item = this.examService.exam.find(x => x.examId == examId);
  console.log("this is Item", item);
  this.dialog.open(EditExamComponent, { data: item });
  }

  ViewExam(sectionId:number) {
    this.examService.GetExamBySection(sectionId);
    this.sectionService.SetSection(sectionId);
  
  }

}

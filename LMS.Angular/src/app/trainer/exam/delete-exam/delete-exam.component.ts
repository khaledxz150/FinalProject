import { Component, Inject, Input, OnInit, ViewChild } from '@angular/core';
import { MatDialog, MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { ExamServiceService } from 'src/app/Service/exam-service.service';
import { SectionService } from 'src/app/Service/section.service';

@Component({
  selector: 'app-delete-exam',
  templateUrl: './delete-exam.component.html',
  styleUrls: ['./delete-exam.component.css']
})
export class DeleteExamComponent implements OnInit {
  constructor(public examService: ExamServiceService, public sectionService:SectionService,@Inject(MAT_DIALOG_DATA) public data: any) { }
  ngOnInit(): void {
  }
  Delete(){
    this.examService.DeleteExam(this.data)
  }
}

import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { ExamService } from 'src/app/Service/exam.service';
import { CreateExamComponent } from '../exam/create-exam/create-exam.component';

@Component({
  selector: 'app-task',
  templateUrl: './task.component.html',
  styleUrls: ['./task.component.css',
       '../../../assets/table/style.css']
})
export class TaskComponent implements OnInit {

  constructor(public examService:ExamService,
    private dialog: MatDialog,private router:Router) { }

  ngOnInit(): void {
  }
  DeleteExam(sectionId: number){};


}

import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { Router } from '@angular/router';
import { MySectionService } from 'src/app/Service/my-section.service';

@Component({
  selector: 'app-exam-info',
  templateUrl: './exam-info.component.html',
  styleUrls: ['./exam-info.component.css']
})
export class ExamInfoComponent implements OnInit {

  constructor(private dialog:MatDialog,public router:Router,public mySectionService:MySectionService) { }
  ngOnInit(): void {
  }
  StartExam(examId:number){
    console.log("Start Exam Now ")
    this.router.navigate(['client','questions'])
    this.dialog.closeAll()
  }


}

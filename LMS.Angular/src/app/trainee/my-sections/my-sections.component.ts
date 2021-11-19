import { Component, OnInit } from '@angular/core';
import {MatDialog} from '@angular/material/dialog';
import { Router } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import { AboutusComponent } from 'src/app/pages/aboutus/aboutus.component';
import { CourseService } from 'src/app/Service/course.service';
import { MySectionService } from 'src/app/Service/my-section.service';
import { AddCommentComponent } from '../add-comment/add-comment.component';
import { ExamInfoComponent } from '../exam-info/exam-info.component';
import { RateBoxComponent } from '../rate-box/rate-box.component';
import { TaskInfoComponent } from '../task-info/task-info.component';
@Component({
  selector: 'app-my-sections',
  templateUrl: './my-sections.component.html',
  styleUrls: ['./my-sections.component.css'
  , '../../../assets/css/default.css',
  '../../../assets/css/slick.css',
  '../../../assets/css/style.css'
  ,'../../../assets/css/animate.css']
})
export class MySectionsComponent implements OnInit {

  constructor(public dialog:MatDialog,private router:Router,
    private toastr:ToastrService,public mySectionService:MySectionService,
    public courseService:CourseService
    ) { }

  ngOnInit(): void {

    let user:any = localStorage.getItem('user');
    let trainee = JSON.parse(user);
    //  if(traineeId){
    //  }

    this.mySectionService.GetMySectionInfo(parseInt(trainee.TraineeId));
    this.mySectionService.GetSectionUnit(1);
    this.mySectionService.GetSectionTask()
    this.mySectionService.GetSectionExam()
    this.courseService.GetCourseComments(1);
  }

  RateCourse(){
   this.dialog.open(RateBoxComponent);
  }
  AddComent(){
    this.dialog.open(AddCommentComponent,{
      height: '90%',
      width: '70%'
  })
  }
  OpenExamInfo(examId:number){
    this.mySectionService.GetExamInfoById(examId)
    this.dialog.open(ExamInfoComponent,{
      height: '80%',
      width: '60%'
  });
  }

  OpenTaskInfo(taskId:number){
    this.mySectionService.GetSectionInfoById(taskId);
    this.dialog.open(TaskInfoComponent,{
      height: '83%',
      width: '98%'
  });
  }

}

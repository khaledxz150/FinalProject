import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LearningService } from 'src/app/Service/learning.service';
import { CourseService } from 'src/app/Service/course.service';

@Component({
  selector: 'app-my-leaning',
  templateUrl: './my-leaning.component.html',
  styleUrls: ['./my-leaning.component.css'
, '../../../assets/css/default.css',
'../../../assets/css/slick.css',
'../../../assets/css/style.css'
,'../../../assets/css/animate.css']
})
export class MyLeaningComponent implements OnInit {

  constructor(public learningService:LearningService,private router:Router
    ,public courseService:CourseService) { }
 //س
  ngOnInit(): void {
    this.learningService.GetAllEnrollmentCourses(2)
    this.courseService.getAllAvailableCourse()
  }
  DisplayCourseInfo(id:number|undefined){
    this.courseService.GetSingleCourseInfoById(id)
    this.router.navigate(['client','courseInfo',id])
 }
///
  MoveToSeeSectionInfo(id:number|undefined){
    this.router.navigate(['client','sectionInfo',id])
  }

  MoveToRecordingCourses(){
    this.router.navigate(['client','video'])
  }

  MovingToLiveCourses(){
    this.router.navigate(['client','sections'])
  }

}

import { Component, OnInit } from '@angular/core';
import { LearningService } from 'src/app/Service/learning.service';

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

  constructor(public learningService:LearningService) { }
 //س
  ngOnInit(): void {
    this.learningService.GetAllEnrollmentCourses(2)
    this.learningService.GetAllLiveCourses(2)
    this.learningService.GetOnlineCourses()
  }

}

import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { CourseService } from 'src/app/Service/course.service';

@Component({
  selector: 'app-courses',
  templateUrl: './courses.component.html',
  styleUrls: ['./courses.component.css'
  , '../../../assets/css/default.css',
  '../../../assets/css/slick.css',
  '../../../assets/css/style.css'
  ,'../../../assets/css/animate.css']
})
export class CoursesComponent implements OnInit {


  constructor(public courseService:CourseService,public router:Router) { }

  ngOnInit(): void {
    this.courseService.getAllAvailableCourse()
  }
  getLink(coureId:number|undefined){
    navigator.clipboard.writeText
    ('http://localhost:4200/pages/courseInfo'+'/'+coureId).then().catch(e => console.error(e));
  }
  DisplayCourseInfo(id:number|undefined){
     this.courseService.GetSingleCourseInfoById(id)
     this.router.navigate(['pages','courseInfo',id])
  }


}

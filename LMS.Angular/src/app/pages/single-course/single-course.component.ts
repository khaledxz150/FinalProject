import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CourseService } from 'src/app/Service/course.service';


@Component({
  selector: 'app-single-course',
  templateUrl: './single-course.component.html',
  styleUrls: ['./single-course.component.css'
  , '../../../assets/css/default.css',
  '../../../assets/css/slick.css',
  '../../../assets/css/style.css'
  ,'../../../assets/css/animate.css']
})
export class SingleCourseComponent implements OnInit {

  constructor(private activatedRoute: ActivatedRoute,
    public router:Router,
    public courseService:CourseService ) { }

  ngOnInit(): void {
    const id = this.activatedRoute.snapshot.paramMap.get('id');
     if(id !=null){
     this.courseService.GetSingleCourseInfoById(parseInt(id));
     this.courseService.GetCourseTopic(parseInt(id));
     this.courseService.GetCourseComments(parseInt(id));
     this.courseService.GetCourseSections(parseInt(id));
     }
     //kkm

  }
  GetSectionInfo(sectionId:number|undefined){
    this.router.navigate(['client','sectionInfo',sectionId])
  }

}
